namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid recipientUserId, Guid requestedByUserId) : base(recipientUserId)
        {
            if (recipientUserId == Guid.Empty)
                throw new ArgumentException("RecipientUserId cannot be empty.");
            if (requestedByUserId == Guid.Empty)
                throw new ArgumentException("RequestedByUserId cannot be empty.");

            RequestedByUserId = requestedByUserId;
            SetMessage($"User {requestedByUserId} sent you a friend request.");
        }

        public Guid RequestedByUserId { get; private set; }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }
    }
}