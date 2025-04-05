using factopia_backend.Api.DTOs.User;
using factopia_backend.Api.Mappers;
using factopia_backend.Api.Tools;
using factopia_backend.BLL.Services.Interfaces;
using factopia_backend.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace factopia_backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        private readonly JwtGenerator _jwtGenerator;

        public AuthController(IAuthService service, JwtGenerator jwtGenerator)
        {
            _service = service;
            _jwtGenerator = jwtGenerator;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterFormUserDTO form)
        {
            if (!ModelState.IsValid) return BadRequest("Erreur lors de la soumission du formulaire.");

            User user = await _service.RegisterAsync(form.ToRegisterEntity());
            string token = _jwtGenerator.Generate(user);

            return Ok(token);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginFormUserDTO form)
        {
            User user = await _service.LoginAsync(form.Email, form.Password);
            string token = _jwtGenerator.Generate(user);

            return Ok(token);
        }

    }
}
