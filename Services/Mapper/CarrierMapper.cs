using AutoMapper;
using Entities;

namespace Services
{
    /// <summary>
    /// Carrier mapper.
    /// </summary>
    public class CarrierMapper : BaseMapper<Carrier, CarrierDto>, ICarrierMapper
    {
        /// <summary>
        /// Creates CarrierMapper object.
        /// </summary>
        public CarrierMapper() : base()
        {
        }
    }
}