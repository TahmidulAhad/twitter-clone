namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        public Guid UserId { get; private set; }
        public Guid TweetId { get; private set; }
        public string? Comment { get; private set; }

        public Retweet(Guid userId, Guid tweetId, string? comment = null) : base(Guid.NewGuid())
        {
            UserId = userId;
            TweetId = tweetId;
            SetComment(comment);
        }

        private void SetComment(string? comment)
        {
            if (string.IsNullOrWhiteSpace(comment))
                return;

            if (comment.Length > 280)
                throw new ArgumentException("Comment cannot exceed 280 characters.");

            Comment = comment;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}, Comment: {Comment}";
        }
    }
}