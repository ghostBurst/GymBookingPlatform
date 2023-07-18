using Microsoft.AspNetCore.Mvc;
using GymBookingPlatform.Data;
using GymBookingPlatform.Models;
using System.Linq;

namespace GymBookingPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GymsController : ControllerBase
    {
        private readonly GymBookingContext _context;

        public GymsController(GymBookingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var gyms = _context.Gyms.ToList();
            return Ok(gyms);
        }
    }
}
