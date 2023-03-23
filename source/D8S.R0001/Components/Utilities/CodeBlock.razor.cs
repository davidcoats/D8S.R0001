using System;

using R5T.T0154;


namespace D8S.R0001
{
    /// <summary>
    /// Chooses <see cref="CodeBlockWithPre"/> as the default.
    /// With-preformatting is chosen as the default since code is
    /// <para>
    /// However! This can lead to surprises. For example, if the child content is indented, all that indentation will appear on the page.
    /// This means that child content should be un-indented, and that can look funny in the Razor component source code.
    /// </para>
    /// </summary>
    [RazorComponentMarker]
    public partial class CodeBlock : IRazorComponentMarker
    {
    }
}
