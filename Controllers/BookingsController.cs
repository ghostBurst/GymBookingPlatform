using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GymBookingPlatform.Data;
using GymBookingPlatform.Models;

namespace GymBookingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly GymBookingContext _context;

        public BookingsController(GymBookingContext context)
        {
            _context = context;
        }

        // POST: api/Bookings
        [HttpPost]
        public ActionResult<Booking> CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetBooking), new { id = booking.Id }, booking);
        }

        // GET: api/Bookings/{id}
        [HttpGet("{id}")]
        public ActionResult<Booking> GetBooking(int id)
        {
            var booking = _context.Bookings.Find(id);

            if (booking == null)
            {
                return NotFound();
            }

            return booking;
        }

        // PUT: api/Bookings/{id}/cancel
        [HttpPut("{id}/cancel")]
        public IActionResult CancelBooking(int id)
        {
            var booking = _context.Bookings.Find(id);

            if (booking == null)
            {
                return NotFound();
            }

            booking.IsCancelled = true;
            _context.Bookings.Update(booking);
            _context.SaveChanges();

            return NoContent();
        }

        // GET: api/Bookings/user/{userId}
        [HttpGet("user/{userId}")]
        public ActionResult<IEnumerable<Booking>> GetUserBookings(int userId)
        {
            return _context.Bookings.Where(b => b.User.Id == userId).ToList();
        }
    }
}
