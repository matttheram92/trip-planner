using Microsoft.EntityFrameworkCore;
using TripPlanner.Server.Models;

namespace TripPlanner.Server.Data
{
    public class TripPlannerDbContext : DbContext
    {
        public TripPlannerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
    }
}
