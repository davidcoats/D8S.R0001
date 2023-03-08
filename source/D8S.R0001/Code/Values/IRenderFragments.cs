using System;

using Microsoft.AspNetCore.Components;

using R5T.T0131;


namespace D8S.R0001
{
    [ValuesMarker]
    public partial interface IRenderFragments : IValuesMarker
    {
        public RenderFragment Null => Utilities.Null();
    }
}
