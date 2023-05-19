using assignment2.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetUserDetailsController : Controller
    {
        private readonly IUserService _userService;
        public GetUserDetailsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet, Authorize]
        public IActionResult GetUserDetails()
        {
            return Ok(_userService.GetUserDetails());
        }
    }
}
