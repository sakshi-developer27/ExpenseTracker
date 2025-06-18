using ExpenseTracker.Service.AuthService;
using ExpenseTracker.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserViewModel userViewModel)
        {
            if (userViewModel == null || string.IsNullOrEmpty(userViewModel.Email) || string.IsNullOrEmpty(userViewModel.Password))
            {
                return BadRequest("Invalid user data.");
            }
            var result = await _authService.RegisterAsync(userViewModel);
            if (result)
            {
                return Ok("User registered successfully.");
            }
            return Conflict("User with this email already exists.");
        }
    }
}
