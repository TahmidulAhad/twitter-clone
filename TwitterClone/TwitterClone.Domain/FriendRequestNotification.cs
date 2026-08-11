namespace TwitterClone.Domain
{
    public sealed class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid userId, Guid requestedByUserId, string message = "New friend request") : base(userId, message)
        {
            if (requestedByUserId == Guid.Empty)
                throw new ArgumentException("RequestedByUserId cannot be empty.");

            RequestedByUserId = requestedByUserId;
        }

        public Guid RequestedByUserId { get; private set; }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }
    }
}