using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
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

            };

            return Ok(users);
        }
    }
}
