using Microsoft.AspNetCore.Mvc;
using AuthWebAPI.Services;
using AuthWebAPI.Model;
using Microsoft.AspNetCore.Authorization;

namespace AuthWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Login(string email,string password)
        {
            User user = await _userService.ValidateUser(email, password);

            if (user == null)
            {
                return BadRequest();
            }
            return Ok(new
            {
                message = "Login Successful!!",

            });

        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}




