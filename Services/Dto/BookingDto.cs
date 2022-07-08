using System.ComponentModel.DataAnnotations;
using Entities;

namespace Services
{
    /// <summary>
    /// Booking DTO.
    /// </summary>
    public class BookingDto : BaseDto
    {
        /// <summary>
        /// Booking No.
        /// </summary>
        public int BookingNo { get; set; }

        /// <summary>
        /// Passenger.
        /// </summary>
        public long PassengerID { get; set; }

        /// <summary>
        /// Passport.
        /// </summary>
        public long PassportID { get; set; }

        /// <summary>
        /// Flight.
        /// </summary>
        public long FlightId { get; set; }
    }
}
