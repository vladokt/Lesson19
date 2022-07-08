using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Booking entity.
    /// </summary>
    public class Booking : BaseEntity
    {
        /// <summary>
        /// Booking No.
        /// </summary>
        public int BookingNo { get; set; }

        /// <summary>
        /// Passenger.
        /// </summary>
        public long PassengerID { get; set; }
        public virtual Passenger Passenger { get; set; } = null!;

        /// <summary>
        /// Passport.
        /// </summary>
        public long PassportID { get; set; }
        public virtual Passport Passport { get; set; } = null!;

        /// <summary>
        /// Flight.
        /// </summary>
        public long FlightId { get; set; }
        public virtual ICollection<Flight> Flights { get; set; } = null!;
    }
}
