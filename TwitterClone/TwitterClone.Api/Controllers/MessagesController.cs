using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    // /api/messages
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessagesController : ControllerBase
    {
        // POST: /api/messages
        [HttpPost]
        public IActionResult SendMessage()
        {
            return CreatedAtAction(nameof(GetMessageById), new { id = Guid.NewGuid() }, new
            {
                message = "Message sent successfully"
            });
        }


        // GET: /api/messages
        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok(new
            {
                message = "Messages retrieved successfully"
            });
        }


        // GET: /api/messages/{id}
        [HttpGet("{id}")]
        public IActionResult GetMessageById(Guid id)
        {
            return Ok(new
            {
                message = "Message retrieved successfully"
            });
        }


        // POST: /api/messages/conversation/{conversationId}
        [HttpPost("conversation/{conversationId}")]
        public IActionResult SendMessageToConversation(Guid conversationId)
        {
            return Ok(new
            {
                message = "Message sent successfully to the conversation"
            });
        }


        // DELETE: /api/messages/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(Guid id)
        {
            return NoContent();
        }


        // DELETE: /api/messages/delete-all
        [HttpDelete("delete-all")]
        public IActionResult DeleteMessages()
        {
            return NoContent();
        }


        // PATCH: /api/messages/{id}/mark-as-read
        [HttpPatch("{id}/mark-as-read")]
        public IActionResult MarkMessageAsRead(Guid id)
        {
            return Ok(new
            {
                message = "Message marked as read successfully"
            });
        }
    }
}
