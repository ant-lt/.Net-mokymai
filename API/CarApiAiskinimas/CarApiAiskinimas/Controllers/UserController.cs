using CarApiAiskinimas.Repositories;
using CarApiAiskinimas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarApiAiskinimas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;

        public UserController(IUserRepository userRepository,
            IUserService userService,
            IJwtService jwtService)
        {
            _userRepository = userRepository;
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginDto model)
        {
            var isOk = _userRepository.TryLogin(model.UserName, model.Password, out var user);
            if (!isOk)
                return Unauthorized("Bad username or password");

            var token = _jwtService.GetJwtToken(user.Id, user.Role);


            return Ok(new LoginResult { UserName = model.UserName, Token = token });
        }
    }





    public class LoginDto
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
    public class LoginResult
    {
        public string? UserName { get; set; }
        public string? Token { get; set; }
    }
}
