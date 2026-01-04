ng.RazorExtensionAssemblyNameAttribute.#ctor(System.String,System.String)">
            <summary>
            Creates a new instance of <see cref="T:Microsoft.AspNetCore.Razor.Hosting.RazorExtensionAssemblyNameAttribute"/>.
            </summary>
            <param name="extensionName">The name of the extension.</param>
            <param name="assemblyName">The assembly name of the extension.</param>
        </member>
        <member name="P:Microsoft.AspNetCore.Razor.Hosting.RazorExtensionAssemblyNameAttribute.AssemblyName">
            <summary>
            Gets the assembly name of the extension.
            </summary>
        </member>
        <member name="P:Microsoft.AspNetCore.Razor.Hosting.RazorExtensionAssemblyNameAttribute.ExtensionName">
            <summary>
            Gets the name of the extension.
            </summary>
        </member>
        <member name="T:Microsoft.AspNetCore.Razor.Hosting.RazorLanguageVersionAttribute">
            <summary>
            Specifies the name of a Razor configuration as defined by the Razor SDK.
            </summary>
            <remarks>
            This attribute is part of a set of metadata attributes that can be applied to an assembly at build
            time by the Razor SDK. These attributes allow the Razor configuration to be loaded at runtime based
            on the settings originally provided by the project file.
            </remarks>
        </member>
        <member name="M:Microsoft.AspNetCore.Razor.Hosting.RazorLanguageVersionAttribute.#ctor(System.String)">
            <summary>
            Creates a new instance of <see cref="T:Microsoft.AspNetCore.Razor.Hosting.RazorLanguageVersionAttribute"/>.
            </summary>
            <param name="languageVersion">The language version of Razor</param>
        </member>
        <member name="P:Microsoft.AspNetCore.Razor.Hosting.RazorLanguageVersionAttribute.LanguageVersion">
            <summary>
            Gets the Razor language version.
            </summary>
        </member>
        <member name="T:Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute">
            <summary>
            Specifies the checksum of a source file that contributed to a compiled item.
            </summary>
            <remarks>
            <para>
            These attributes are added by the Razor infrastructure when generating code to assist runtime
            implementations to determine the integrity of compiled items.
            </para>
            <para>
            Runtime implementations should access the checksum metadata for an item using
            <see cref="M:Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemExtensions.GetChecksumMetadata(Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItem)"/>.
            </para>
            </remarks>
        </member>
        <member name="M:Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute.#ctor(System.String,System.String,System.String)">
            <summary>
            Creates a new <see cref="T:Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute"/>.
            </summary>
            <param name="checksumAlgorithm">The algorithm used to create this checksum.</param>
            <param name="checksum">The checksum as a string of hex-encoded bytes.</param>
            <param name="identifier">The identifier associated with this thumbprint.</param>
        </member>
        <member name="P:Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute.Checksum">
            <summary>
            Gets the checksum as string of hex-encoded bytes.
            </summary>
        </member>
        <member name="P:Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute.ChecksumAlgorithm">
            <summary>
            Gets the name of the algorithm used to create this checksum.
            </summary>
        </member>
        <member name="P:Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute.Identifier">
            <summary>
            Gets the identifier of the source file associated with this checksum.
            </summary>
        </member>
        <member name="T:Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext">
            <summary>
            Class used to store information about a <see cref="T:Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper"/>'s execution lifetime.
            </summary>
        </member>
        <member name="M:Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext.#ctor(System.String,Microsoft.AspNetCore.Razor.TagHelpers.TagMode)">
            <summary>
            Internal for testing purposes only.
            </summary>
        </member>
        <member name="M:Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext.#ctor(System.String,Microsoft.AspNetCore.Razor.TagHelpers.TagMode,System.Collections.Generic.IDictionary{System.Object,System.Object},System.String,System.Func{System.Threading.Tasks.Task},System.Action{System.Text.Encodings.Web.HtmlEncoder},System.Func{Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent})">
            <summary>
            Instantiates a new <