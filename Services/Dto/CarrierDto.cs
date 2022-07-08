using System.ComponentModel.DataAnnotations;
using Entities;

namespace Services
{
    /// <summary>
    /// Carrier DTO.
    /// </summary>
    public class CarrierDto : BaseDto
    {
        /// <summary>
        /// Carrier.
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; } = "";

        /// <summary>
        /// Country.
        /// </summary>
        [MaxLength(50)]
        public string Country { get; set; } = "";

        /// <summary>
        /// Carrier bonus.
        /// </summary>
        public long? PassengerId { get; set; }
    }
}
