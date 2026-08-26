namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikable
    {
        public Guid UserId { get; private set; }
        public string Content { get; private set; } = string.Empty;
        public static int MaxContentLength = 200;

        public Tweet(Guid userId, string content) : base(Guid.NewGuid())
        {
            UserId = userId;
            SetContent(content);
        }

        public Tweet(string content) : base(Guid.NewGuid())
        {
            SetContent(content);
        }

        public void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Tweet cannot be empty.");

            if (content.Length > MaxContentLength)
                throw new ArgumentException($"Tweet cannot exceed {MaxContentLength} characters.");

            Content = content;
        }

        public void Update(Guid userId, string content)
        {
            UserId = userId;
            SetContent(content);
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
        }

        public bool CanBeLiked()
        {
            return !string.IsNullOrWhiteSpace(Content);
        }
    }
}
