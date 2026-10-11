using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Api.Data;
using TwitterClone.Api.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    // api/users
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UsersController(
            UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // /api/users
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetUsers()
        {          
            var users = _userRepository.GetAllUsers();
            return Ok(users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email
            }));
        }


        // /api/users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody] CreateUserDto createUserDto)
        {
            if (string.IsNullOrWhiteSpace(createUserDto.FirstName) ||
                string.IsNullOrWhiteSpace(createUserDto.LastName) ||
                string.IsNullOrWhiteSpace(createUserDto.Email))
            {
                return BadRequest("First name, last name, and email are required.");
            }

            var existingUser = _userRepository.GetUserByEmail(createUserDto.Email);
            if (existingUser != null)
            {
                return BadRequest("A user with this email already exists.");
            }

            var createdUser = _userRepository.AddUser(new User(
                createUserDto.FirstName,
                createUserDto.LastName,
                createUserDto.Email
            ));

            return Ok(new UserDto
            {
                Id = createdUser.Id,
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Email = createUserDto.Email
            });
        }


        // /api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            var user = _userRepository.GetUserById(id);

            if(user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            });
        }


        // Put /api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = _userRepository.GetUserById(id);
            if(user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            user.UpdateName(updateUserDto.FirstName, updateUserDto.LastName);
            _userRepository.UpdateUser(user);

            return Ok(new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
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
            var user = _userRepository.GetUserById(id);
            if(user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            var isDeleted = _userRepository.DeleteUser(user);
            return Ok(isDeleted);
        }
    }
}
