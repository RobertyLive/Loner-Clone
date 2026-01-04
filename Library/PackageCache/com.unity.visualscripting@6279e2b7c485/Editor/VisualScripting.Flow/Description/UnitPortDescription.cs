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
            Instantiates a new <see cref="T:Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext"/>.
            </summary>
            <param name="tagName">The HTML tag name in the Razor source.</param>
            <param name="tagMode">HTML syntax of the element in the Razor source.</param>
            <param name="items">The collection of items used to communicate with other
            <see cref="T:Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper"/>s</param>
            <param name="uniqueId">An identifier unique to the HTML element this context is for.</param>
            <param name="executeChildContentAsync">A delegate used to execute the child content asynchronously.</param>
            <param name="startTagHelperWritingScope">
            A delegate used to start a writing scope in a Razor page and optionally override the page's
