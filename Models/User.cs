﻿using System.Collections.Generic;

namespace GymBookingPlatform.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
