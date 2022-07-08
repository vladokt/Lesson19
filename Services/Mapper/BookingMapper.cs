using AutoMapper;
using Entities;

namespace Services
{
    /// <summary>
    /// Booking mapper.
    /// </summary>
    public class BookingMapper : BaseMapper<Booking, BookingDto>, IBookingMapper
    {
        /// <summary>
        /// Creates BookingMapper object.
        /// </summary>
        public BookingMapper() : base()
        {
        }
    }
}