using AutoMapper;
using Entities;

namespace Services
{
    /// <summary>
    /// Passport mapper.
    /// </summary>
    public class PassportMapper : BaseMapper<Passport, PassportDto>, IPassportMapper
    {
        /// <summary>
        /// Creates PassportMapper object.
        /// </summary>
        public PassportMapper() : base()
        {
        }
    }
}
