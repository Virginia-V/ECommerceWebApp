using ECommerce.Bll.Interfaces;
using ECommerce.Common.Dtos.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/")]
    public class UsersController : AppBaseController
    {

        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto)
        {

            var response = await _userService.RegisterAsync(registerUserDto);
            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest(new RegistrationResponseDto()
            {
                Result = false,
                Errors = new List<string>()
                {
                    "Invalid payload"
                }
            });

        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginUserDto loginUserDto)
        {

            var response = await _userService.LoginAsync(loginUserDto);
            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest(new LoginResponseDto()
            {
                Result = false,
                Errors = new List<string>()
                {
                    "Invalid payload"
                }
            });

        }
    }
}
