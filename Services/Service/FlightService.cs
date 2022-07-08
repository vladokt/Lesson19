using Microsoft.EntityFrameworkCore;
using Entities;
using DB;

namespace Services
{
    /// <summary>
    /// Flight service.
    /// </summary>
    public class FlightService : Service<Flight, FlightDto>, IFlightService
    {
        /// <summary>
        /// Creates FlightService object.
        /// </summary>
        /// <param name="context">AppDbContext object.</param>
        /// <param name="mapper">IFlightMapper object.</param>
        public FlightService(AppDbContext context, IFlightMapper mapper) : base(context, mapper)
        {
        }
    }
}