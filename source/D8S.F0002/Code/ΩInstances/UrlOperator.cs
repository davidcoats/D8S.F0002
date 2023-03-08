using System;


namespace D8S.F0002
{
    public class UrlOperator : IUrlOperator
    {
        #region Infrastructure

        public static IUrlOperator Instance { get; } = new UrlOperator();


        private UrlOperator()
        {
        }

        #endregion
    }
}
