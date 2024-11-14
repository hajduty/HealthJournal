using HealthJournal.Dto.Account;
using HealthJournal.Interfaces;
using HealthJournal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthJournal.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenService _tokenService;

        public AccountController(UserManager<User> userManager, ITokenService tokenService, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == loginDto.Email.ToLower());

            if (user == null) return Unauthorized("Invalid email");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (!result.Succeeded) return Unauthorized("Password or email incorrect");

            var newUser = new NewUserDto { Email = user.Email, Token = _tokenService.CreateToken(user).Result };
            return Ok(newUser);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new User
            {
                Email = registerDto.Email,
                UserName = registerDto.Email,
            };

            var registeredUser = await _userManager.CreateAsync(user, registerDto.Password);

            if (!registeredUser.Succeeded)
                return BadRequest("User registration failed.");

            var roleResult = await _userManager.AddToRoleAsync(user, "Patient");

            if (!roleResult.Succeeded)
                return BadRequest("Role assignment failed.");

            var userDto = new NewUserDto
            {
                Email = user.Email,
                Token = _tokenService.CreateToken(user).Result
            };

            return Ok(userDto);
        }
    }
}
