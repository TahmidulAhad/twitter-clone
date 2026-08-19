namespace TwitterClone.Domain.Entities
{
    public sealed class LikeNotification : Notification
    {
        public LikeNotification(Guid likerId, Guid tweetId) : base("Like")
        {
            if (likerId == Guid.Empty)
                throw new ArgumentException("LikerId cannot be empty.");

            LikerId = likerId;
            TweetId = tweetId;
        }

        public Guid LikerId { get; private set; }
        public Guid TweetId { get; private set; }

        public override string DescribeRecord()
        {
            return $"{base.DescribeRecord()}, LikerId: {LikerId}, TweetId: {TweetId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {LikerId} liked your tweet with ID {TweetId}.";
        }
    }
}
