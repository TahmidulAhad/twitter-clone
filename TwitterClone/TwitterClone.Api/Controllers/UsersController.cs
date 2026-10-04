using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    // api/users
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // /api/users
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<User>
            {
                new User
                (
                    "Tawsif",
                    "Hossain",
                    "tawsif.hossain@example.com"
                ),
                new User
                (
                    "Sayeed",
                    "Ifad",
                    "sayeed.ifad@example.com"
                ),
                new User
                (
                    "Reduan",
                    "Nakib",
                    "reduan.nakib@example.com"
                ),

            };

            return Ok(users);
        }


        // /api/users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody] User user)
        {
            return Ok(new
            {
                userid = Guid.NewGuid(),
                username = "newuser"
            });
        }


        // /api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            return Ok(new
            {
                userid = id,
                username = "user" + id.ToString()
            });
        }


        // Put /api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] User user)
        {
            return Ok(new
            {
                userid = id,
                username = "updateduser" + id.ToString()
            });
        }


        // Patch /api/users/{id}/phoneNumber
        [HttpPatch("{id}/phoneNumber")]
        public IActionResult Updated_PhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok(new
            {
                userid = id,
                phoneNumber = phoneNumber
            });
        }


        // Delete /api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                userid = id,
                message = "User deleted successfully"
            });
        }
    }
}
