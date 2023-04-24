using System;

using R5T.T0132;


namespace D8S.F0002
{
    [FunctionalityMarker]
    public partial interface IUrlOperator : IFunctionalityMarker
    {
        /// <summary>
        /// When uploading an image, puts it at: {S3 Bucket Name}/Blog-Personal/{Article Name Url Segment}/Images/{imageFileNameUrlSegment}.
        /// <para>
        /// This means creating both the {Article Name Url Segment} directory in the bucket, and the Images directory in the article name URL segment directory.
        /// </para>
        /// </summary>
        public string GetArticleImageUrl_Blog_Technical(
            string articleNameUrlSegment,
            string imageFileNameUrlSegment)
        {
            var publicBucketUrl = Instances.Urls.S3PublicBucket;

            var articleImageUrl = $"{publicBucketUrl}/Blog-Technical/Articles/{articleNameUrlSegment}/Images/{imageFileNameUrlSegment}";
            return articleImageUrl;
        }

        /// <summary>
        /// <para>Chooses <see cref="GetArticleImageUrl_Blog_Technical(string, string)"/> as the default.</para>
        /// <inheritdoc cref="GetArticleImageUrl_Blog_Technical(string, string)" path="/summary"/>
        /// </summary>
        public string GetArticleImageUrl(
            string articleNameUrlSegment,
            string imageFileNameUrlSegment)
        {
            return this.GetArticleImageUrl_Blog_Technical(
                articleNameUrlSegment,
                imageFileNameUrlSegment);
        }

        /// <summary>
        /// When uploading an image, puts it at: {S3 Bucket Name}/Blog-Personal/{Article Name Url Segment}/Images/{imageFileNameUrlSegment}.
        /// <para>
        /// This means creating both the {Article Name Url Segment} directory in the bucket, and the Images directory in the article name URL segment directory.
        /// </para>
        /// </summary>
        public string GetArticleImageUrl_Blog_Personal(
            string articleNameUrlSegment,
            string imageFileNameUrlSegment)
        {
            var publicBucketUrl = Instances.Urls.S3PublicBucket;

            var articleImageUrl = $"{publicBucketUrl}/Blog-Personal/Articles/{articleNameUrlSegment}/Images/{imageFileNameUrlSegment}";
            return articleImageUrl;
        }

        /// <summary>
        /// When uploading an image, puts it at: {S3 Bucket Name}/Blog-TheLegFiles/{Article Name Url Segment}/Images/{imageFileNameUrlSegment}.
        /// <para>
        /// This means creating both the {Article Name Url Segment} directory in the bucket, and the Images directory in the article name URL segment directory.
        /// </para>
        /// </summary>
        public string GetArticleImageUrl_Blog_TheLegFiles(
            string articleNameUrlSegment,
            string imageFileNameUrlSegment)
        {
            var publicBucketUrl = Instances.Urls.S3PublicBucket;

            var articleImageUrl = $"{publicBucketUrl}/Blog-TheLegFiles/Articles/{articleNameUrlSegment}/Images/{imageFileNameUrlSegment}";
            return articleImageUrl;
        }
    }
}
