using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API
{
    /// <summary>
    /// Passport controller.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class PassportController : Controller<Passport, PassportDto>
    {
        /// <summary>
        /// Creates PassportController object.
        /// </summary>
        /// <param name="service">IPassportService object.</param>
        public PassportController(IPassportService service) : base(service)
        {
        }

        /// <summary>
        /// Gets all Passport items from database.
        /// </summary>
        /// <returns>List of items.</returns>
        /// <response code="200">Return the list of Passport items.</response>
        [ProducesResponseType(200)]
        public override Task<List<PassportDto>> Get()
        {
            return _service.Get<Passport>();
        }

        /// <summary>
        /// Gets specified by id Passport item.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Passport DTO object.</returns>
        /// <response code="200">Return specified by id Passport item.</response>
        /// <response code="404">If specified Passport item was not found.</response>
        public override Task<PassportDto> GetById(long id)
        {
            return _service.GetById<Passport>(id);
        }

        /// <summary>
        /// Creates new Passport item in database.
        /// </summary>
        /// <param name="dto">Passport DTO object.</param>
        /// <returns>Created item id.</returns>
        /// <response code="200">Return the created Passport item id.</response>
        [ProducesResponseType(200)]
        public override Task<long> Create([FromBody] PassportDto dto)
        {
            return _service.Create<Passport>(dto);
        }

        /// <summary>
        /// Updates existing Passport item.
        /// </summary>
        /// <param name="dto">Passport DTO object.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Passport item successfully updated.</response>
        /// <response code="404">If specified Passport item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Update([FromBody] PassportDto dto)
        {
            return _service.Update<Passport>(dto);
        }

        /// <summary>
        /// Deletes specified by id Passport item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Passport item successfully deleted.</response>
        /// <response code="404">If specified Passport item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Delete(long id)
        {
            return _service.Delete<Passport>(id);
        }
    }
}