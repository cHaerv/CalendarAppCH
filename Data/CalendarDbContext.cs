using Microsoft.EntityFrameworkCore;
using Radzen.Blazor.Rendering;

namespace CalendarAppCH.Data
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options) 
        {
        }

        // DbSet for appointments table
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
