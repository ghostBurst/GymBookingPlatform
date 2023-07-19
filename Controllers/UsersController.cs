using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GymBookingPlatform.Data;
using GymBookingPlatform.Models;

namespace GymBookingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly GymBookingContext _context;

        public UsersController(GymBookingContext context)
        {
            _context = context;
        }

        // POST: api/Users/register
        [HttpPost("register")]
        public ActionResult<User> Register(User user)
        {
            // This is a placeholder. You'll need to replace this with your actual logic for registering a user.
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // POST: api/Users/login
        [HttpPost("login")]
        public ActionResult<User> Login(User user)
        {
            // This is a placeholder. You'll need to replace this with your actual logic for logging in a user.
            return user;
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
    }
}
