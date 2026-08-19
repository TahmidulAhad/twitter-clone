using TwitterClone.Domain.Entities;

var notifications = new List<Notification>()
{
    new LikeNotification(Guid.NewGuid(), Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid(), Guid.NewGuid()),
    new FriendRequestNotification(Guid.NewGuid(), Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid(), Guid.NewGuid()),
};

foreach (var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
}


//var likeNotification = new LikeNotification(Guid.NewGuid(), Guid.NewGuid());
//Console.WriteLine(likeNotification.GetMessage());

//var commentNotification = new CommentNotification(Guid.NewGuid(), Guid.NewGuid());
//Console.WriteLine(commentNotification.GetMessage());

//var friendRequestNotification = new FriendRequestNotification(Guid.NewGuid(), Guid.NewGuid());
//Console.WriteLine(friendRequestNotification.GetMessage());

//var MentionNotification = new MentionNotification(Guid.NewGuid(), Guid.NewGuid());
//Console.WriteLine(MentionNotification.GetMessage());