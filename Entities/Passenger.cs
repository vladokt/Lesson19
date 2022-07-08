using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Passenger entity.
    /// </summary>
    public class Passenger : BaseEntity
    {
        /// <summary>
        /// Surname.
        /// </summary>
        [MaxLength(20)]
        public string Surname { get; set; } = "";

        /// <summary>
        /// Name.
        /// </summary>
        [MaxLength(20)]
        public string Name { get; set; } = "";

        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Passport.
        /// </summary>
        public virtual ICollection<Passport> Passports { get; set; } = null!;

        /// <summary>
        /// Flight.
        /// </summary>
        public virtual ICollection<Flight> Flights { get; set; } = null!;

        /// <summary>
        /// Booking.
        /// </summary>
        public virtual ICollection<Booking> Bookings { get; set; } = null!;

        /// <summary>
        /// Carrier bonus.
        /// </summary>
        public virtual ICollection<Carrier>? Carriers { get; set; }
    }
}