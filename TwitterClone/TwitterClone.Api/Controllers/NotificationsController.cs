using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace TwitterClone.Api.Controllers
{
    // /api/notifications
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationsController : ControllerBase
    {
        // GET: /api/notifications
        [HttpGet]
        public IActionResult GetNotifications()
        {
            return Ok();
        }

        // GET: /api/notifications/unread
        [HttpGet("unread")]
        public IActionResult GetUnreadNotifications()
        {
            return Ok();
        }

        // GET: /api/notifications/unread/count
        [HttpGet("unread/count")]
        public IActionResult GetUnreadNotificationsCount()
        {
            return Ok();
        }

        // POST: /api/notifications/{notificationId}/mark-as-read
        [HttpPost("{notificationId}/mark-as-read")]
        public IActionResult MarkAsRead(Guid notificationId)
        {
            return Ok();
        }

        // PATCH: /api/notifications/mark-all-as-read
        [HttpPatch("mark-all-as-read")]
        public IActionResult MarkAllAsRead(Guid notificationId)
        {
            return NoContent();
        }

        // DELETE: /api/notifications/{notificationId}
        [HttpDelete("{notificationId}")]
        public IActionResult DeleteNotification(Guid notificationId)
        {
            return Ok();
        }

        // DELETE: /api/notifications/delete-all
        [HttpDelete("delete-all")]
        public IActionResult DeleteNotificatons()
        {
            return Ok();
        }
    }
}