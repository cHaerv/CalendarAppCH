using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CalendarAppCH.Data
{
    public class ClalendarDbContextFactory : IDesignTimeDbContextFactory<CalendarDbContext>
    {
        public CalendarDbContext CreateDbContext(string[] args) 
        { 
            // configuration from appsettings.Json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Create options builder
            var optionsBuilder = new DbContextOptionsBuilder<CalendarDbContext>();

            // Configure to use SQLite
            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlite(connectionString);

            return new CalendarDbContext(optionsBuilder.Options);
        }
    }
}
