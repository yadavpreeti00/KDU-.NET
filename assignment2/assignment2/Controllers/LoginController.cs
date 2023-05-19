using assignment2.DTOs;
using assignment2.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        public LoginController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost, Route("login")]
        public IActionResult Login(LoginDTO loginDTO)
        {
            return Ok(_jwtService.GenerateJwtToken(loginDTO));
        }

    }
}
