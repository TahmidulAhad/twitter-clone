namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        public User(string firstName, string lastName, string email) : base(Guid.NewGuid())
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}";
        }
    }
}
