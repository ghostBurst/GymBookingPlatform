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
        [HttpPost]
        public IActionResult Post([FromBody] Gym gym)
        {
            _context.Gyms.Add(gym);
            _context.SaveChanges();
            return Ok(gym);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Gym gym)
        {
            var existingGym = _context.Gyms.Find(id);
            if (existingGym == null)
            {
                return NotFound();
            }

            existingGym.Name = gym.Name;
            existingGym.Location = gym.Location;
            _context.SaveChanges();
            return Ok(existingGym);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var gym = _context.Gyms.Find(id);
            if (gym == null)
            {
                return NotFound();
            }

            _context.Gyms.Remove(gym);
            _context.SaveChanges();
            return Ok(gym);
        }

    }
}
