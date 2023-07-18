using Microsoft.AspNetCore.Mvc;
using GymBookingPlatform.Data;
using GymBookingPlatform.Models;
using System.Linq;

namespace GymBookingPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly GymBookingContext _context;

        public UsersController(GymBookingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }
    }
}
