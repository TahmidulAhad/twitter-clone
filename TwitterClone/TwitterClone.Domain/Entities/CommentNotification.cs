namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        public Guid CommenterId { get; private set; }
        public Guid TweetId { get; private set; }

        public CommentNotification(Guid commenterId, Guid tweetId) : base("Comment")
        {
            if (commenterId == Guid.Empty)
                throw new ArgumentException("CommenterId cannot be empty.", nameof(commenterId));

            if (tweetId == Guid.Empty)
                throw new ArgumentException("TweetId cannot be empty.", nameof(tweetId));

            CommenterId = commenterId;
            TweetId = tweetId;
        }

        public override string DescribeRecord()
        {
            return $"{base.DescribeRecord()}, CommenterId: {CommenterId}, TweetId: {TweetId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {CommenterId} commented on your tweet with ID {TweetId}.";
        }
    }
}