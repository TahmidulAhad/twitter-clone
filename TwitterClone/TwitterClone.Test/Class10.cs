using TwitterClone.Domain.Entities;

namespace TwitterClone.Test
{
    public class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Running class10 ---\n");
            var program = new Class10();
            program.Run();
        }

        public void Run()
        {
            Tweet likeableTweet = new Tweet("This is another tweet!");
            Console.WriteLine(likeableTweet.CanBeLiked());
            var maxTweetLength = 200;
        }
    }
}