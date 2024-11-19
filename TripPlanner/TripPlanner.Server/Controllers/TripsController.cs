using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripPlanner.Server.Data;

namespace TripPlanner.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TripsController : Controller
    {
        private readonly TripPlannerDbContext _context;

        public TripsController(TripPlannerDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTrips()
        {
            var trips = await _context.Trips.ToListAsync();

            return Ok(trips);
        }
    }
}
