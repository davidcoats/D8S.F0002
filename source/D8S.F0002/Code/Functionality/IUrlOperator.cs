using System;

using R5T.T0132;


namespace D8S.F0002
{
    [FunctionalityMarker]
    public partial interface IUrlOperator : IFunctionalityMarker
    {
        public string GetArticleImageUrl(
            string articleNameUrlSegment,
            string imageFileNameUrlSegment)
        {
            var publicBucketUrl = Instances.Urls.S3PublicBucket;

            var articleImageUrl = $"{publicBucketUrl}/Blog-Technical/Articles/{articleNameUrlSegment}/Images/{imageFileNameUrlSegment}";
            return articleImageUrl;
        }
    }
}
