using Microsoft.AspNetCore.Mvc;
using TwitterClone.Api.Data;
using TwitterClone.Api.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    // api/tweets
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly TweetRepository _tweetRepository;
        private readonly UserRepository _userRepository;

        public TweetsController(TweetRepository tweetRepository, UserRepository userRepository)
        {
            _tweetRepository = tweetRepository;
            _userRepository = userRepository;
        }


        // GET /api/tweets?userId={userId}
        [HttpGet]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            List<Tweet> tweets;

            if (userId.HasValue)
            {
                tweets = _tweetRepository.GetTweetsByUserId(userId.Value);
            }
            else
            {
                tweets = _tweetRepository.GetTweets();
            }

            var tweetDtos = tweets.Select(t => new
            {
               Id = t.Id,
               UserId = t.UserId,
               Content = t.Content,       
            });

            return Ok(tweetDtos);
        }


        // GET /api/tweets/{id}
        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if(tweet == null)
            {
                return NotFound();
            }

            TweetDto tweetDto = new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content
            };

            return Ok(tweetDto);
        }

        // POST /api/tweets
        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetRequestDto request)
        {
            if (string.IsNullOrWhiteSpace(request.Content))
            {
                return BadRequest("Content is required");
            }

            var user = _userRepository.GetUserById(request.UserId);

            if(user == null)
            {
                return BadRequest("User does not exist");
            }

            var tweet = new Tweet(request.Content);
            tweet.Update(request.UserId, request.Content);

            _tweetRepository.AddTweet(tweet);

            var tweetDto = new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content
            };

            return Ok(tweetDto);
        }

        // PUT /api/tweets/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute] Guid id, [FromBody] UpdateTweetRequestDto request)
        {
            if (string.IsNullOrWhiteSpace(request.Content))
            {
                return BadRequest("Content is required");
            }

            var tweet = _tweetRepository.GetTweetById(id);

            if(tweet == null)
            {
                return NotFound();
            }

            tweet.SetContent(request.Content);

            _tweetRepository.UpdateTweet(tweet);

            var tweetDto = new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content
            };

            return Ok(tweetDto);
        }

        // DELETE /api/tweets/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound();
            }

            var isDeleted = _tweetRepository.DeleteTweet(tweet);

            return Ok(isDeleted);
        }

    }
}