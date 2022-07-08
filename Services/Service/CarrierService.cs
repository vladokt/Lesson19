using Microsoft.EntityFrameworkCore;
using Entities;
using DB;

namespace Services
{
    /// <summary>
    /// Carrier service.
    /// </summary>
    public class CarrierService : Service<Carrier, CarrierDto>, ICarrierService
    {
        /// <summary>
        /// Creates CarrierService object.
        /// </summary>
        /// <param name="context">AppDbContext object.</param>
        /// <param name="mapper">ICarrierMapper object.</param>
        public CarrierService(AppDbContext context, ICarrierMapper mapper) : base(context, mapper)
        {
        }
    }
}
