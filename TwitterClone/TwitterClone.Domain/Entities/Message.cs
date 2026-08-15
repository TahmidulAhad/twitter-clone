namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        public Guid SenderId { get; private set; }
        public Guid ReceiverId { get; private set; }
        public string Content { get; private set; }
        public bool IsRead { get; private set; }

        public Message(Guid senderId, Guid receiverId, string content) : base(Guid.NewGuid())
        {
            if (senderId == receiverId)
                throw new ArgumentException("Sender and receiver cannot be the same.");

            SenderId = senderId;
            ReceiverId = receiverId;
            SetContent(content);
            IsRead = false;
        }

        public void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Message cannot be empty.");

            Content = content;
        }
        public void MarkAsRead()
        {
            IsRead = true;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, SenderId: {SenderId}, ReceiverId: {ReceiverId}, Content: {Content}, IsRead: {IsRead}";
        }
    }
}