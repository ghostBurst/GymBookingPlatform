using System.Collections.Generic;

namespace GymBookingPlatform.Models
{
    public class Gym
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
