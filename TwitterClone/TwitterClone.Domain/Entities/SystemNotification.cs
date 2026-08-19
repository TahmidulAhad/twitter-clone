namespace TwitterClone.Domain.Entities
{
    public sealed class SystemNotification : Notification
    {
        public SystemNotification() : base("System")
        {
        }

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }
        public override string GetMessage()
        {
            return "This is a system notification.";
        }

    }
}