using System;


namespace D8S.R0001
{
    public class RenderFragments : IRenderFragments
    {
        #region Infrastructure

        public static IRenderFragments Instance { get; } = new RenderFragments();


        private RenderFragments()
        {
        }

        #endregion
    }
}
