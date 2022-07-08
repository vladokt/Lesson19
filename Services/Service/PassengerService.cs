using Microsoft.EntityFrameworkCore;
using Entities;
using DB;

namespace Services
{
    /// <summary>
    /// Passenger service.
    /// </summary>
    public class PassengerService : Service<Passenger, PassengerDto>, IPassengerService
    {
        /// <summary>
        /// creates PassengerService object.
        /// </summary>
        /// <param name="context">AppDbContext object.</param>
        /// <param name="mapper">IPassengerMapper object.</param>
        public PassengerService(AppDbContext context, IPassengerMapper mapper) : base(context, mapper)
        {
        }
    }
}
