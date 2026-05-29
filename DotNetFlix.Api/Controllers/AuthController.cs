using DotNetFlix.Api.DTOs.Request.Auth;
using DotNetFlix.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFlix.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(
            IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(
            RegisterRequest dto)
        {
            await _authService.RegisterAsync(dto.ToModel());

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(
            LoginRequest dto)
        {
            var response =
                await _authService.LoginAsync(dto.ToModel());

            return Ok(response);
        }
    }
}