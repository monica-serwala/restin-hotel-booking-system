using Microsoft.EntityFrameworkCore;
using HotelBookingManagementSystem.Models;

namespace HotelBookingManagementSystem.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Bedroom> Bedrooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
