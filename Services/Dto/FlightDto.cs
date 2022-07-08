using System.ComponentModel.DataAnnotations;
using Entities;

namespace Services
{
    /// <summary>
    /// Flight DTO.
    /// </summary>
    public class FlightDto : BaseDto
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

        /// <summary>
        /// Carrier.
        /// </summary>
        public long CarrierId { get; set; }
    }
}
