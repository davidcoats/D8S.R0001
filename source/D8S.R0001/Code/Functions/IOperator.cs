using System;

using R5T.T0132;
using R5T.T0143;


namespace D8S.R0001
{
    [FunctionalityMarker]
    public partial interface IOperator :
        R5T.F0100.IOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public R5T.F0100.IOperator _R5T_F0100 => R5T.F0100.Operator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
