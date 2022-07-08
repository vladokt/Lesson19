using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// Carrier entity
    /// </summary>
    public class Carrier : BaseEntity
    {
        /// <summary>
        /// Carrier
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; } = "";

        /// <summary>
        /// Country
        /// </summary>
        [MaxLength(50)]
        public string Country { get; set; } = "";

        /// <summary>
        /// Flight
        /// </summary>
        public virtual ICollection<Flight> Flights { get; set; } = null!;

        /// <summary>
        /// Carrier bonus
        /// </summary>
        public long? PassengerId { get; set; }
        public virtual ICollection<Passenger>? Passengers { get; set; }
    }
}
