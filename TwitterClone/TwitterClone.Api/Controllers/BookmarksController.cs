using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    // /api/bookmarks
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookmarksController : ControllerBase
    {
        // POST: /api/bookmarks/{id}
        [HttpPost("{id}")]
        public IActionResult AddBookmark(Guid id)
        {
            return Ok();
        }


        // DELETE: /api/bookmarks/{id}
        [HttpDelete("{id}")]
        public IActionResult RemoveBookmark(Guid id)
        {
            return NoContent();
        }


        // DELETE: /api/bookmarks
        [HttpDelete]
        public IActionResult RemoveAllBookmark()
        {
            return NoContent();
        }


        // GET: /api/bookmarks
        [HttpGet]
        public IActionResult GetBookmarks()
        {
            return Ok();
        }
        

        // GET: /api/bookmarks/{id}/status
        [HttpGet("{id}/status")]
        public IActionResult GetBookmarkStatus(Guid id)
        {
            return Ok();
        }
    }
}
