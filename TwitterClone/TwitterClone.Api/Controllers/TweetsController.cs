using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TweetsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
            {
                new Tweet(Guid.NewGuid(), "This is my first tweet!"),
                new Tweet(Guid.NewGuid(), "This is my second tweet!"),
                new Tweet(Guid.NewGuid(), "This is my third tweet!")
            };

            return Ok(tweets);
        }
    }
}
