using AutoMapper;
using Entities;

namespace Services
{
    /// <summary>
    /// Passenger mapper.
    /// </summary>
    public class PassengerMapper : BaseMapper<Passenger, PassengerDto>, IPassengerMapper
    {
        /// <summary>
        /// Creates PassengerMapper object.
        /// </summary>
        public PassengerMapper() : base()
        {

        }
    }
}
