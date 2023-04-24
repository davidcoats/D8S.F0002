using System;

using R5T.T0131;


namespace D8S.F0002
{
    [ValuesMarker]
    public partial interface IUrls : IValuesMarker
    {
        /// <summary>
        /// public.bucket.8acc798b-9220-4d85-9a78-551f46ec1dd2
        /// </summary>
        public string S3PublicBucket => "https://s3.us-west-1.amazonaws.com/public.bucket.8acc798b-9220-4d85-9a78-551f46ec1dd2";
    }
}
