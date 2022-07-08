using Microsoft.EntityFrameworkCore;
using Entities;
using DB;

namespace Services
{
    /// <summary>
    /// Booking service.
    /// </summary>
    public class BookingService : Service<Booking, BookingDto>, IBookingService
    {
        /// <summary>
        /// Creates BookingService object.
        /// </summary>
        /// <param name="context">AppDbContext object.</param>
        /// <param name="mapper">IBookingMapper object.</param>
        public BookingService(AppDbContext context, IBookingMapper mapper) : base(context, mapper)
        {
        }
    }
}