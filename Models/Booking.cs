namespace GymBookingPlatform.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Gym Gym { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsCancelled { get; set; }
    }
}
