using Microsoft.EntityFrameworkCore;
using GymBookingPlatform.Models;

namespace GymBookingPlatform.Data
{
    public class GymBookingContext : DbContext
    {
        public GymBookingContext(DbContextOptions<GymBookingContext> options)
            : base(options)
        {
        }

        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
