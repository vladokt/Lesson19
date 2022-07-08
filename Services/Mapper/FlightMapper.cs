using AutoMapper;
using Entities;

namespace Services
{
    /// <summary>
    /// Flight mapper.
    /// </summary>
    public class FlightMapper : BaseMapper<Flight, FlightDto>, IFlightMapper
    {
        /// <summary>
        /// Creates FlightMapper object.
        /// </summary>
        public FlightMapper() : base()
        {
        }
    }
}