using System;

using R5T.T0154;


namespace D8S.R0001
{
    /// <summary>
    /// Represents a code block with child content surrounded by &lt;pre&gt;&lt;code&gt;
    /// HTML 5 recommends putting &lt;code&gt; inside &lt;pre&gt;, not the other way around.
    /// See <see href="https://stackoverflow.com/questions/11742907/why-does-html5-recommend-putting-the-code-element-inside-pre"/>.
    /// </summary>
    [RazorComponentMarker]
    public partial class CodeBlockWithPre : IRazorComponentMarker
    {

    }
}
