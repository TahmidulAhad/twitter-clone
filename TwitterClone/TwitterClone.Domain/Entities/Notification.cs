namespace TwitterClone.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public Guid UserId { get; private set; }
        public string? Type { get; private set; }
        public string? Message { get; protected set; }
        public bool IsRead { get; private set; }

        public Notification(string notificationType) : base(Guid.NewGuid())
        {
            Type = notificationType;
            IsRead = false;
        }

        protected Notification(Guid userId) : base(Guid.NewGuid())
        {
            UserId = userId;
            Message = string.Empty;
            IsRead = false;
        }

        public void SetMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Notification message cannot be empty.");
            Message = message;
        }
        public void MarkAsRead()
        {
            IsRead = true;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Message: {Message}, IsRead: {IsRead}";
        }
    }
}