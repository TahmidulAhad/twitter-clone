namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        public Guid FollowerId { get; private set; }
        public Guid FollowingId { get; private set; }

        public Follow(Guid followerId, Guid followingId) : base(Guid.NewGuid())
        {
            if (followerId == followingId)
                throw new ArgumentException("A user cannot follow themselves.");

            FollowerId = followerId;
            FollowingId = followingId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FollowerId: {FollowerId}, FollowingId: {FollowingId}";
        }
    }
}