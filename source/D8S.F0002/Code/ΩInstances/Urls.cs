using System;


namespace D8S.F0002
{
    public class Urls : IUrls
    {
        #region Infrastructure

        public static IUrls Instance { get; } = new Urls();


        private Urls()
        {
        }

        #endregion
    }
}
