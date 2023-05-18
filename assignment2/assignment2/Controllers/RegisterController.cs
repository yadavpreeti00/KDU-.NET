using assignment2.DTOs;
using assignment2.Interface;
using assignment2.Service;
using Microsoft.AspNetCore.Mvc;

namespace assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        private readonly IUserService _userService;
        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost, Route("register")]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            _userService.RegisterUser(registerDTO);
            return Ok("User registered Successfully");
           
        }
    }
}
