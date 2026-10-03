using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LikesController : ControllerBase
    {
        [HttpPost("{tweetId}/like")]
        public IActionResult LikeTweet(int tweetId)
        {
            return Ok(new
            {
                message = "Tweet liked successfully"
            });
        }


        // DELETE: /api/likes/{tweetId}/unlike
        [HttpDelete("{tweetId}/unlike")]
        public IActionResult UnlikeTweet(Guid tweetId)
        {
            return NoContent();
        }


        // GET: /api/likes/{tweetId}/status/{userId}
        [HttpGet("{tweetId}/status/{userId}")]
        public IActionResult GetLikeStatus(Guid tweetId, Guid userId)
        {
            return Ok();
        }


        // GET: /api/likes/{tweetId}/count
        [HttpGet("{tweetId}/count")]
        public IActionResult GetLikeCount(Guid tweetId)
        {
            int count = 0;
            return Ok(count);
        }


        // GET: /api/likes/user/{userId}
        [HttpGet("user/{userId}")]
        public IActionResult GetLikedTweets(Guid userId)
        {
            return Ok();
        }
    }
}
