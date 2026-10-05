namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
    {
        public User(string firstName, string lastName, string email, string? phoneNumber = null)
            : base(Guid.NewGuid())
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _inComingNotifications = new List<Guid>();

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string? PhoneNumber { get; private set; }

        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void UpdateEmail(string email)
        {
            Email = email;
        }

        public void UpdatePhoneNumber(string? phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, PhoneNumber: {PhoneNumber}";
        }

        public void Follow(Guid userId)
        {
            if (!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }

        public void Unfollow(Guid userId)
        {
            if (_followers.Contains(userId))
            {
                _followers.Remove(userId);
            }
        }

        public void AddNotification(Guid notificationId)
        {
            if (!_inComingNotifications.Contains(notificationId))
            {
                _inComingNotifications.Add(notificationId);
            }
        }
    }
}