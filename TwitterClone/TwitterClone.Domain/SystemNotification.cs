namespace TwitterClone.Domain
{
    public sealed class SystemNotification : Notification
    {
        public SystemNotification() : base(Guid.Empty, "System")
        {
        }

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }
    }
}