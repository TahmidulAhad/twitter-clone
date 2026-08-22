using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionerId, Guid tweetId) : base("Mention")
        {
            if (mentionerId == Guid.Empty)
                throw new ArgumentException("MentionerId cannot be empty.");
            MentionerId = mentionerId;
            TweetId = tweetId;
        }
        public Guid MentionerId { get; private set; }
        public Guid TweetId { get; private set; }
        public override string DescribeRecord()
        {
            return $"{base.DescribeRecord()}, MentionerId: {MentionerId}, TweetId: {TweetId}";
        }
        public override string GetMessage()
        {
            return $"User with ID {MentionerId} mentioned you in a tweet with ID {TweetId}.";
        }
    }
}
