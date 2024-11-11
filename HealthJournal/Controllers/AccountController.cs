using HealthJournal.Dto.Account;
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

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
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
                    UserName = registerDto.UserName,
                };

                var registeredUser = await _userManager.CreateAsync(user, registerDto.Password);

                if (registeredUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, "Patient");

                    if (roleResult.Succeeded)
                        return Ok("User created"); // Return JWT token

                    return BadRequest(roleResult);
                } else
                {
                    return BadRequest(registeredUser);
                }

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
