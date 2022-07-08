using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Flight entity.
    /// </summary>
    public class Flight : BaseEntity
    {
        /// <summary>
        /// Flight No.
        /// </summary>
        public int FlightNo { get; set; }

        /// <summary>
        /// Departure.
        /// </summary>
        [MaxLength(20)]
        public string Departure { get; set; } = "";

        /// <summary>
        /// Arrival.
        /// </summary>
        [MaxLength(20)]
        public string Arrival { get; set; } = "";

        /// <summary>
        /// Date and time.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Passenger.
        /// </summary>
        public long PassengerId { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; } = null!;

        /// <summary>
        /// Booking.
        /// </summary>
        public virtual ICollection<Booking> Bookings { get; set; } = null!;

        /// <summary>
        /// Carrier.
        /// </summary>
        public long CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; } = null!;
    }
}
