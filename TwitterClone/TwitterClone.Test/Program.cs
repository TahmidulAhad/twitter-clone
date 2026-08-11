using System;
using TwitterClone.Domain;

namespace TwitterClone.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Twitter Clone Domain Tester");
            Console.WriteLine("---------------------------\n");

            try
            {
              
                var user1 = new User("ahad", "ahad@gmail.com", "password123");
                var user2 = new User("rahman", "rahman@gmail.com", "password123");

                Console.WriteLine($"Created User 1: {user1.DescribeRecord()}");
                Console.WriteLine($"Created User 2: {user2.DescribeRecord()}\n");

                var tweet = new Tweet(user1.Id, "Bismillahir Rahmanir Rahim, this is my first tweet on this clone!");
                Console.WriteLine($"Created Tweet: {tweet.DescribeRecord()}\n");

                var retweet = new Retweet(user2.Id, tweet.Id, "Nice tweet, Ahad!");
                Console.WriteLine($"Created Retweet: {retweet.DescribeRecord()}\n");

                var friendRequest = new FriendRequestNotification(user2.Id, user1.Id);
                Console.WriteLine($"Created Friend Request Notification: {friendRequest.DescribeRecord()}\n");

                var message = new Message(user1.Id, user2.Id, "Hey Rahman, how are you?");
                Console.WriteLine($"Created Message from Ahad to Rahman: {message.Content}\n");

                Console.WriteLine("All domain entities tested successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }
    }
}
