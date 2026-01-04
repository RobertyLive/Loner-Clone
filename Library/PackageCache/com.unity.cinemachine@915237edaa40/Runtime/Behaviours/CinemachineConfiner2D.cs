<?xml version="1.0" encoding="utf-8"?>
<doc>
  <assembly>
    <name>System.Formats.Tar</name>
  </assembly>
  <members>
    <member name="T:System.Formats.Tar.GnuTarEntry">
      <summary>Represents a tar entry in the GNU format.</summary>
    </member>
    <member name="M:System.Formats.Tar.GnuTarEntry.#ctor(System.Formats.Tar.TarEntry)">
      <summary>Initializes a new <see cref="T:System.Formats.Tar.GnuTarEntry" /> instance by converting the specified <paramref name="other" /> entry into the GNU format.</summary>
      <param name="other">The <see cref="T:System.Formats.Tar.TarEntry" /> instance to convert to the GNU format.</param>
      <exception cref="T:System.ArgumentException">
        <paramref name="other" /> is a <see cref="T:System.Formats.Tar.PaxGlobalExtendedAttributesTarEntry" /> instance.

-or-

The entry type of <paramref name="other" /> is not supported in the GNU format.</exception>
    </member>
    <member name="M:System.Formats.Tar.GnuTarEntry.#ctor(System.Formats.Tar.TarEntryType,System.String)">
      <summary>Initializes a new <see cref="T:System.Formats.Tar.GnuTarEntry" /> instance with the specified entry type and entry name.</summary>
      <param name="entryType">The type of the entry.</param>
      <param name="entryName">A string with the path and file name of this entry.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="entryName" /> is <see langword="null" />.</exception>
      <exception cref="T:System.ArgumentException">
        <paramref name="entryName" /> is empty.

-or-

The entry type is not supported for creating an entry in the GNU format.</exception>
    </member>
    <member name="P:System.Formats.Tar.GnuTarEntry.AccessTime">
      <summary>A timestamp that represents the last time the file represented by this entry was accessed.</summary>
    </member>
    <member name="P:System.Formats.Tar.GnuTarEntry.ChangeTime">
      <summary>A timestamp that represents the last time the metadata of the file represented by this entry was changed.</summary>
    </member>
    <member name="T:System.Formats.Tar.PaxGlobalExtendedAttributesTarEntry">
      <summary>Represents a global extended attributes tar entry of the PAX format.</summary>
    </member>
    <member name="M:System.Formats.Tar.PaxGlobalExtendedAttributesTarEntry.#ctor(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{System.String,System.String}})">
      <summary>Initializes a new <see cref="T:System.Formats.Tar.PaxGlobalExtendedAttributesTarEntry" /> instance with the specified global extended attributes enumeration.</summary>
      <param name="globalExtendedAttributes">An enumeration of string key-value pairs that represents the metadata to include as global extended attributes.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="globalExtendedAttributes" /> is <see langword="null" />.</exception>
    </member>
    <member name="P:System.Formats.Tar.PaxGlobalExtendedAttributesTarEntry.GlobalExtendedAttributes">
      <summary>Returns the global extended attributes stored in this entry.</summary>
    </member>
    <member name="T:System.Formats.Tar.PaxTarEntry">
      <summary>Represents a tar entry in the PAX format.</summary>
    </member>
    <member name="M:System.Formats.Tar.PaxTarEntry.#ctor(System.Formats.Tar.TarEntry)">
      <summary>Initializes a new <see cref="T:System.Formats.Tar.PaxTarEntry" /> instance by converting the specified <paramref name="other" /> entry into the PAX format.</summary>
      <param name="other">The <see cref="T:System.Formats.Tar.TarEntry" /> instance to convert to the PAX format.</param>
      <exception cref="T:System.ArgumentException">
        <paramref name="other" /> is a <see cref="T:System.Formats.Tar.PaxGlobalExtendedAttributesTarEntry" /> instance.

-or-

The entry type of <paramref name="other" /> is not supported in the PAX format.</exception>
    </member>
    <member name="M:System.Formats.Tar.PaxTarEntry.#ctor(System.Formats.Tar.TarEntryType,System.String,System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{System.String,System.String}})">
      <summary>Initializes a new <see cref="T:System.Formats.Tar.PaxTarEntry" /> instance with the specified entry type, entry name, and extended attributes enumeration.</summary>
      <param name="entryType">The type of the entry.</param>
      <param name="entryName">A string with the path and file name of this entry.</param>
      <param name="extendedAttributes">An enumeration of string key-value pairs that represents the metadata to include in the extended attributes entry that precedes the current entry.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="extendedAttributes" /> or <paramref name="entryName" /> is <see langword="null" />.</exception>
      <exception cref="T:System.ArgumentException">
        <paramref name="entryName" /> is empty.

-or-

The entry type is not supported for creating an entry in the PAX format.</exception>
    </member>
    <member name="M:System.Formats.Tar.PaxTarEntry.#ctor(System.Formats.Tar.TarEntryType,System.String)">
      <summary>Initializes a new <see cref="T:System.Formats.Tar.PaxTarEntry" /> instance with the specified entry type and entry name, and the default extended attributes.</summary>
      <param name="entryType">The type of the entry.</param>
      <param name="entryName">A string with the path and file name of this entry.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="entryName" /> is <see langword="null" />.</exception>
      <exception cref="T:System.ArgumentException">
        <paramref name="entryName" /> is empty.

-or-

The entry type is not supported for creating an entry in the PAX format.</exception>
    </member>
    <member name="P:System.Formats.Tar.PaxTarEntry.ExtendedAttributes">
      <summary>Returns the extended attributes for this entry.</summary>
    </member>
    <member name="T:System.Formats.Tar.PosixTarEntry">
      <summary>Defines the core behavior of a tar entry from an archive of a format that is based on the POSIX IEEE P1003.1 standard from 1988. This includes the formats <see cref="F:System.Formats.Tar.TarEntryFormat.Ustar" /> (represented by the <see cref="T:System.Formats.Tar.UstarTarEntry" /> class), <see cref="F:System.Formats.Tar.TarEntryFormat.Pax" /> (represented by the <see cref="T:System.Formats.Tar.PaxTarEntry" /> class), and <see cref="F:System.Formats.Tar.TarEntryFormat.Gnu" /> (represented by the <see cref="T:System.Formats.Tar.GnuTarEntry" /> class).</summary>
    </member>
    <member name="P:System.Formats.Tar.PosixTarEntry.DeviceMajor">
      <summary>Gets or sets the device's major number. When the current entry represents a character device or a block device, the major number identifies the driver associated with the device.</summary>
      <exception cref="T:System.InvalidOperationException">The entry does not represent a block device or a character device.</exception>
      <exception cref="T:System.ArgumentOutOfRangeException">The value is negative, or larger than 2097151.</exception>
    </member>
    <member name="P:System.Formats.Tar.PosixTarEntry.DeviceMinor">
      <summary>Gets or sets the device's minor number. When the current entry represents a character device or a block device, the minor number is used by the driver to distinguish individual devices it controls.</summary>
      <exception cref="T:System.InvalidOperationException">The entry does not represent a block device or a character device.</exception>
      <exception cref="T:System.ArgumentOutOfRangeException">The value is negative, or larger than 2097151.</exception>
    </member>
    <member name="P:System.Formats.Tar.PosixTarEntry.GroupName">
      <summary>Gets or sets the name of the group that owns this entry.</summary>
      <exception cref="T:System.ArgumentNullException">The group name is <see langword="null" />.</exception>
    </member>
    <member name="P:System.Formats.Tar.PosixTarEntry.UserName">
      <summary>Gets or sets the name of the user that owns this entry.</summary>
      <exception cref="T:System.ArgumentNullException">The user name is <see langword="null" />.</exception>
    </member>
    <member name="T:System.Formats.Tar.TarEntry">
      <summary>Defines the core behavior of a tar entry from an archive.</summary>
    </member>
    <member name="M:System.Formats.Tar.TarEntry.ExtractToFile(System.String,System.Boolean)">
      <summary>Extracts the current file or directory to the filesystem. Symbolic links and hard links are not extracted.</summary>
      <param name="destinationFileName">The path to the destination file.</param>
      <param name="overwrite">
        <see langword="true" /> if this method should overwrite any existing filesystem object located in the <paramref name="destinationFileName" /> path; <see langword="false" /> to prevent overwriting.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="destinationFileName" /> is <see langword="null" />.</exception>
      <exception cref="T:System.ArgumentException">
        <paramref name="destinationFileName" /> is empty.</exception>
      <exception cref="T:System.IO.IOException">
The parent directory of <paramref name="destinationFileName" /> does not exist.

-or-

<paramref name="overwrite" /> is <see langword="false" /> and a file already exists in <paramref name="destinationFileName" />.

-or-

A directory exists with the same name as <paramref name="destinationFileName" />.

-or-

An I/O problem occurred.</exception>
      <exception cref="T:System.InvalidOperationException">Attempted to extract a symbolic link, a hard link, or an unsupported entry type.</exception>
      <exception cref="T:System.UnauthorizedAccessException">Operation not permitted due to insufficient permissions.</exception>
    </member>
    <member name="M:System.Formats.Tar.TarEntry.ExtractToFileAsync(System.String,System.Boolean,System.Threading.CancellationToken)">
      <summary>Asynchronously extracts the current entry to the filesystem.</summary>
      <param name="destinationFileName">The path to the destination file.</param>
      <param name="overwrite">
        <see langword="true" /> if this method should overwrite any existing filesystem object located in the <paramref name="destinationFileName" /> path; <see langword="false" /> to prevent overwriting.</param>
      <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="destinationFileName" /> is <see langword="null" />.</exception>
      <exception cref="T:System.ArgumentException">
        <paramref name="destinationFileName" /> is empty.</exception>
      <exception cref="T:System.IO.IOException">
The parent directory of <paramref name="destinationFileName" /> does not exist.

-or-

<paramref name="overwrite" /> is <see langword="false" /> and a file already exists in <paramref name="destinationFileName" />.

-or-

A directory exists with the same name as <paramref name="destinationFileName" />.

-or-

An I/O problem occurred.</exception>
      <exception cref="T:System.InvalidOperationException">The entry type is unsupported.</exception>
      <exception cref="T:System.UnauthorizedAccessException">Permissions are insufficient.</exception>
      <exception cref="T:System.OperationCanceledException">The cancellation token was canceled. This exception is stored into the returned task.</exception>
      <returns>A task that represents the asynchronous extraction operation.</returns>
    </member>
    <member name="M:System.Formats.Tar.TarEntry.ToString">
      <summary>Returns a string that represents the current entry.</summary>
      <returns>The <see cref="P:System.Formats.Tar.TarEntry.Name" /> of the current entry.</returns>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.Checksum">
      <summary>The checksum of all the fields in this entry. The value is non-zero either when the entry is read from an existing archive, or after the entry is written to a new archive.</summary>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.DataOffset">
      <summary>Gets the starting position of the data stream respective to the archive stream.</summary>
      <returns>A number that represents a position in a stream.</returns>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.DataStream">
      <summary>Gets or sets the data section of this entry. If the <see cref="P:System.Formats.Tar.TarEntry.EntryType" /> does not support containing data, then returns <see langword="null" />.</summary>
      <exception cref="T:System.InvalidOperationException">Setting a data section is not supported because the <see cref="P:System.Formats.Tar.TarEntry.EntryType" /> is not <see cref="F:System.Formats.Tar.TarEntryType.RegularFile" /> (or <see cref="F:System.Formats.Tar.TarEntryType.V7RegularFile" /> for an archive of <see cref="F:System.Formats.Tar.TarEntryFormat.V7" /> format).</exception>
      <exception cref="T:System.ArgumentException">The stream does not support reading.</exception>
      <exception cref="T:System.IO.IOException">An I/O problem occurred.</exception>
      <returns>
        <para>Gets a stream that represents the data section of this entry.</para>
        <para>Sets a new stream that represents the data section, if it makes sense for the <see cref="P:System.Formats.Tar.TarEntry.EntryType" /> to contain data. If a stream already exists, the old stream is disposed before substituting it with the new stream. Setting a <see langword="null" /> stream is allowed.</para>
      </returns>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.EntryType">
      <summary>Gets the type of filesystem object represented by this entry.</summary>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.Format">
      <summary>The format of the entry.</summary>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.Gid">
      <summary>Gets or sets the ID of the group that owns the file represented by this entry.</summary>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.Length">
      <summary>When the <see cref="P:System.Formats.Tar.TarEntry.EntryType" /> indicates an entry that can contain data, gets the length in bytes of such data.</summary>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.LinkName">
      <summary>When the <see cref="P:System.Formats.Tar.TarEntry.EntryType" /> indicates a <see cref="F:System.Formats.Tar.TarEntryType.SymbolicLink" /> or a <see cref="F:System.Formats.Tar.TarEntryType.HardLink" />, gets or sets the link target path of the link.</summary>
      <exception cref="T:System.InvalidOperationException">The entry type is not <see cref="F:System.Formats.Tar.TarEntryType.HardLink" /> or <see cref="F:System.Formats.Tar.TarEntryType.SymbolicLink" />.</exception>
      <exception cref="T:System.ArgumentNullException">The specified value is <see langword="null" />.</exception>
      <exception cref="T:System.ArgumentException">The specified value is empty.</exception>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.Mode">
      <summary>Gets or sets the Unix file permissions of the file represented by this entry.</summary>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.ModificationTime">
      <summary>Gets or sets the last time the contents of the file represented by this entry were modified.</summary>
      <exception cref="T:System.ArgumentOutOfRangeException">The specified value is larger than <see cref="F:System.DateTimeOffset.UnixEpoch" />.</exception>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.Name">
      <summary>Gets or sets the name of the entry, which includes the relative path and the filename.</summary>
    </member>
    <member name="P:System.Formats.Tar.TarEntry.Uid">
      <summary>Gets or sets the ID of the user that owns the file represented by this entry.</summary>
    </member>
    <member name="T:System.Formats.Tar.TarEntryFormat">
      <summary>Specifies the supported formats that tar entries can use.</summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryFormat.Gnu">
      <summary>GNU tar entry format (gnu).</summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryFormat.Pax">
      <summary>POSIX IEEE 1003.1-2001 ("POSIX.1") Pax Interchange tar entry format.</summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryFormat.Unknown">
      <summary>Tar entry format undetermined.</summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryFormat.Ustar">
      <summary>POSIX IEEE 1003.1-1988 Unix Standard tar entry format.</summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryFormat.V7">
      <summary>1979 Version 7 AT&amp;T Unix tar entry format.</summary>
    </member>
    <member name="T:System.Formats.Tar.TarEntryType">
      <summary>Specifies the tar entry types.</summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryType.BlockDevice">
      <summary>
        <para>Block device special file.</para>
        <para>This entry type is supported only in the Unix platforms for writing.</para>
      </summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryType.CharacterDevice">
      <summary>
        <para>Character device special file.</para>
        <para>This entry type is supported only in the Unix platforms for writing.</para>
      </summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryType.ContiguousFile">
      <summary>
        <para>GNU contiguous file.</para>
        <para>This entry type is specific to the <see cref="F:System.Formats.Tar.TarEntryFormat.Gnu" /> format, and is treated as a <see cref="F:System.Formats.Tar.TarEntryType.RegularFile" /> entry type.</para>
      </summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryType.Directory">
      <summary>Directory.</summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryType.DirectoryList">
      <summary>
        <para>GNU directory with a list of entries.</para>
        <para>This entry type is specific to the <see cref="F:System.Formats.Tar.TarEntryFormat.Gnu" /> format, and is treated as a <see cref="F:System.Formats.Tar.TarEntryType.Directory" /> entry type that contains a data section.</para>
      </summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryType.ExtendedAttributes">
      <summary>
        <para>PAX Extended Attributes entry.</para>
        <para>Metadata entry type.</para>
      </summary>
    </member>
    <member name="F:System.Formats.Tar.TarEntryType.Fifo">
      <summary>
        <para>FIFO special file.</para>
        <para>This entry type is supported only in the Unix platforms for writing.</para>
      </summary>
    </member>
    <membe