using System;


namespace D8S.R0001
{
    public static class Instances
    {
        public static R5T.F0000.IDateTimeOperator DateTimeOperator => R5T.F0000.DateTimeOperator.Instance;
        public static IOperator Operator => R0001.Operator.Instance;
        public static R5T.L0066.IStringOperator StringOperator => R5T.L0066.StringOperator.Instance;
        public static R5T.L0066.IStrings Strings => R5T.L0066.Strings.Instance;
    }
}