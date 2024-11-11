using HealthJournal.Dto.Account;
using HealthJournal.Interfaces;
using HealthJournal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HealthJournal.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public AccountController(UserManager<User> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = new User
                {
                    Email = registerDto.Email,
                    UserName = registerDto.Email,
                };

                var registeredUser = await _userManager.CreateAsync(user, registerDto.Password);

                if (registeredUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, "Patient");

                    if (roleResult.Succeeded)
                    {
                        var userDto = new NewUserDto
                        {
                            Email = user.Email,
                            Token = _tokenService.CreateToken(user)
                        };

                        return Ok(userDto);
                    }


                    return BadRequest(roleResult);
                }
                else
                {
                    return BadRequest(registeredUser);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
