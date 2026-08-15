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

    }
}