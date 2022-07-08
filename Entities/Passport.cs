using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Passport entity.
    /// </summary>
    public class Passport : BaseEntity
    {
        /// <summary>
        /// Passport No.
        /// </summary>
        public int PassportNo { get; set; }

        /// <summary>
        /// Date of issue.
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Passenger id.
        /// </summary>
        public long PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; } = null!;

        /// <summary>
        /// Booking.
        /// </summary>
        public virtual ICollection<Booking> Bookings { get; set; } = null!;
    }
}
