using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Authenticator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _service;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _service = userService;
        }

        [HttpGet("{userId}", Name = "GetUserById")]
        public async Task<ActionResult<Usuario?>> GetUserAsync(int userId)
        {
            try
            {
                var user = await _service.GetById(userId);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching user with ID {UserId}", userId);
                return BadRequest("An error occurred while fetching user.");
            }
        }

        [HttpPost("Signup")]
        public async Task<ActionResult<Usuario?>> Signup([FromBody] SignupUserDTO userDto)
        {
            try
            {
                var user = await _service.Signup(userDto);
                return CreatedAtAction(nameof(GetUserAsync), user);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "An argumentError occurred while signing up user");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while signing up user");
                return BadRequest("An error occurred while signing up user.");
            }
        }

        [HttpPost("Signin")]
        public async Task<ActionResult<Usuario?>> Signin([FromBody] SigninUserDTO userDto)
        {
            try
            {
                var user = await _service.Signin(userDto);
                if (user == null)
                {
                    return NotFound("User not found");
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while signing in user");
                return BadRequest("An error occurred while signing in user.");
            }
        }
    }
}
