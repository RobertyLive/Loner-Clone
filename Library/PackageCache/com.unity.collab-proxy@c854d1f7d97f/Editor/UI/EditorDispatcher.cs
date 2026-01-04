<browsers>
    <browser id="IE" parentID="Mozilla">
        <identification>
            <userAgent match="^Mozilla[^(]*\([C|c]ompatible;\s*MSIE (?'version'(?'major'\d+)(?'minor'\.\d+)(?'letters'\w*))(?'extra'[^)]*)" />
            <userAgent nonMatch="Opera|Go\.Web|Windows CE|EudoraWeb" />
        </identification>

        <capture>
        </capture>

        <capabilities>
            <capability name="browser"              value="IE" />
            <capability name="extra"                value="${extra}" />
            <capability name="isColor"              value="true" />
            <capability name="letters"              value="${letters}" />
            <capability name="majorversion"         value="${major}" />
            <capability name="m