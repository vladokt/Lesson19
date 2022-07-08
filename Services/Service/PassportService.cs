using Microsoft.EntityFrameworkCore;
using Entities;
using DB;

namespace Services
{
    /// <summary>
    /// Passport service.
    /// </summary>
    public class PassportService : Service<Passport, PassportDto>, IPassportService
    {
        /// <summary>
        /// Creates PassportService object.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public PassportService(AppDbContext context, IPassportMapper mapper) : base(context, mapper)
        {
        }
    }
}