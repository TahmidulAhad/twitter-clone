namespace TwitterClone.Domain
{
    public class Notification : BaseEntity
    {
        public Guid UserId { get; private set; }
        public string Message { get; private set; }
        public bool IsRead { get; private set; }

        public Notification(Guid userId, string message) : base(Guid.NewGuid())
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Notification message cannot be empty.");
            UserId = userId;
            Message = message;
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