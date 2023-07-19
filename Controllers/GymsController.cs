using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GymBookingPlatform.Data;
using GymBookingPlatform.Models;

namespace GymBookingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymsController : ControllerBase
    {
        private readonly GymBookingContext _context;

        public GymsController(GymBookingContext context)
        {
            _context = context;
        }

        // GET: api/Gyms?location={location}&activities={activities}
        [HttpGet]
        public ActionResult<IEnumerable<Gym>> GetGyms(string location, string activities)
        {
            var gyms = _context.Gyms.AsQueryable();

            if (!string.IsNullOrEmpty(location))
            {
                gyms = gyms.Where(g => g.Location == location);
            }

            if (!string.IsNullOrEmpty(activities))
            {
                gyms = gyms.Where(g => g.Activities.Contains(activities));
            }

            return gyms.ToList();
        }

        // GET: api/Gyms/{id}/availability?date={date}&time={time}
        [HttpGet("{id}/availability")]
        public ActionResult<bool> CheckAvailability(int id, string date, string time)
        {
            // This is a placeholder. You'll need to replace this with your actual logic for checking availability.
            return true;
        }
    }
}
