######################## BEGIN LICENSE BLOCK ########################
# The Original Code is Mozilla Universal charset detector code.
#
# The Initial Developer of the Original Code is
# Netscape Communications Corporation.
# Portions created by the Initial Developer are Copyright (C) 2001
# the Initial Developer. All Rights Reserved.
#
# Contributor(s):
#   Mark Pilgrim - port to Python
#   Shy Shalom - original C code
#
# This library is free software; you can redistribute it and/or
# modify it under the terms of the GNU Lesser General Public
# License as published by the Free Software Foundation; either
# version 2.1 of the License, or (at your option) any later version.
#
# This library is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
# Lesser General Public License for more details.
#
# You should have received a copy of the GNU Lesser General Public
# License along with this library; if not, write to the Free Software
# Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
# 02110-1301  USA
######################### END LICENSE BLOCK #########################
"""
Module containing the UniversalDetector detector class, which is the primary
class a user of ``chardet`` should use.

:author: Mark Pilgrim (initial port to Python)
:author: Shy Shalom (original C code)
:author: Dan Blanchard (major refactoring for 3.0)
:author: Ian Cordasco
"""


import codecs
import logging
import re
from typing import List, Optional, Union

from .charsetgroupprober import CharSetGroupProber
from .charsetprober import CharSetProber
from .enums import InputState, LanguageFilter, ProbingState
from .escprober import EscCharSetProber
from .latin1prober import Latin1Prober
from .macromanprober import MacRomanProber
from .mbcsgroupprober import MBCSGroupProber
from .resultdict import ResultDict
from .sbcsgroupprober import SBCSGroupProber
from .utf1632prober import UTF1632Prober


class UniversalDetector:
    """
    The ``UniversalDetector`` class underlies the ``chardet.detect`` function
    and coordinates all of the different charset probers.

    To get a ``dict`` containing an encoding and its confidence, you can simply
    run:

    .. code::

            u = UniversalDetector()
            u.feed(some_bytes)
            u.close()
            detected = u.result

    """

    MINIMUM_THRESHOLD = 0.20
    HIGH_BYTE_DETECTOR = re.compile(b"[\x80-\xFF]")
    ESC_DETECTOR = re.compile(b"(\033|~{)")
    WIN_BYTE_DETECTOR = re.compile(b"[\x80-\x9F]")
    ISO_WIN_MAP = {
        "iso-8859-1": "Windows-1252",
        "iso-8859-2": "Windows-1250",
        "iso-8859-5": "Windows-1251",
        "iso-8859-6": "Windows-1256",
        "iso-8859-7": "Windows-1253",
        "iso-8859-8": "Windows-1255",
        "iso-8859-9": "Windows-1254",
        "iso-8859-13": "Windows-1257",
    }
    # Based on https://encoding.spec.whatwg.org/#names-and-labels
    # but altered to match Python names for encodings and remove mappings
    # that break tests.
    LEGACY_MAP = {
        "ascii": "Windows-1252",
        "iso-8859-1": "Windows-1252",
        "tis-620": "ISO-8859-11",
        "iso-8859-9": "Windows-1254",
        "gb2312": "GB18030",
        "euc-kr": "CP949",
        "utf-16le": "UTF-16",
    }

    def __init__(
        self,
        lang_filter: LanguageFilter = LanguageFilter.ALL,
        should_rename_legacy: bool = False,
    ) -> None:
        self._esc_charset_prober: Optional[EscCharSetProber] = None
        self._utf1632_prober: Optional[UTF1632Prober] = None
        self._charset_probers: List[CharSetProber] = []
        self.result: ResultDict = {
            "encoding": None,
            "confidence": 0.0,
            "language": None,
        }
        self.done = False
        self._got_data = False
        self._input_state = InputState.PURE_ASCII
        self._last_char = b""
        self.lang_filter = lang_filter
        self.logger = logging.getLogger(__name__)
        self._has_win_bytes = False
        self.should_rename_legacy = should_rename_legacy
        self.reset()

    @property
    def input_state(self) -> int:
        return self._input_state

    @property
    def has_win_bytes(self) -> bool:
        return self._has_win_bytes

    @property
    def charset_probers(self) -> List[CharSetProber]:
        return self._charset_probers

    def reset(self) -> None:
        """
        Reset the UniversalDetector and all of its probers back to their
        initial states.  This is called by ``__init__``, so you only need to
        call this directly in between analyses of different documents.
        """
        self.result = {"encoding": None, "confidence": 0.0, "language": None}
        self.done = False
        self._got_data = False
        self._has_win_bytes = False
        self._input_state = InputState.PURE_ASCII
        self._last_char = b""
        if self._esc_charset_prober:
            self._esc_charset_prober.reset()
        if self._utf1632_prober:
            self._utf1632_prober.reset()
        for prober in self._charset_probers:
            prober.reset()

    def feed(self, byte_str: Union[bytes, bytearray]) -> None:
        """
        Takes a chunk of a document and feeds it through all of the relevant
        charset probers.

        After calling ``feed``, you can check the value of the ``done``
        attribute to see if you need to continue feeding the
        ``UniversalDetector`` more data, or if it has made a prediction
        (in the ``result`` attribute).

        .. note::
           You should always call ``close`` when you're done feeding in your
           document if ``done`` is not already ``True``.
        """
        if self.done:
            return

    