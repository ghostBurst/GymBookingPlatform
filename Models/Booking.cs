using System;

namespace GymBookingPlatform.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Gym Gym { get; set; }
    }
}
