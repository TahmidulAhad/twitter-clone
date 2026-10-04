using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    // / api/retweets
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReTweetsController : ControllerBase
    {
        // POST: /api/retweets/{id}
        [HttpPost("{id}")]
        public IActionResult ReTweet([FromBody] Guid id)
        {
            return Ok(new
            {
                message = "ReTweet created successfully"
            });
        }

        // GET: /api/retweets
        [HttpGet]
        public IActionResult GetReTweets()
        {
            return Ok(new
            {
                message = "ReTweetsController is working!"
            });
        }

        // DELETE: /api/retweets/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReTweet(Guid id)
        {
            return Ok(new
            {
                message = "ReTweet deleted successfully"
            });
        }

        // GET: /api/retweets/{id}/status
        [HttpGet("{id}/status")]
        public IActionResult GetReTweetStatus(Guid id)
        {
            return Ok(new
            {
                message = "ReTweet status retrieved successfully"
            });
        }
    }
}
