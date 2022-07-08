using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API
{
    /// <summary>
    /// Carrier controller.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CarrierController : Controller<Carrier, CarrierDto>
    {
        /// <summary>
        /// Creates CarrierController object.
        /// </summary>
        /// <param name="service">ICarrierService object.</param>
        public CarrierController(ICarrierService service) : base(service)
        {
        }

        /// <summary>
        /// Gets all Carrier items from database.
        /// </summary>
        /// <returns>List of items.</returns>
        /// <response code="200">Return the list of Carrier items.</response>
        [ProducesResponseType(200)]
        public override Task<List<CarrierDto>> Get()
        {
            return _service.Get<Carrier>();
        }

        /// <summary>
        /// Gets specified by id Carrier item.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Carrier DTO object.</returns>
        /// <response code="200">Return specified by id Carrier item.</response>
        /// <response code="404">If specified Carrier item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task<CarrierDto> GetById(long id)
        {
            return _service.GetById<Carrier>(id);
        }

        /// <summary>
        /// Creates new Carrier item in database.
        /// </summary>
        /// <param name="dto">Carrier DTO object.</param>
        /// <returns>Created item id.</returns>
        /// <response code="200">Return the created Carrier item id.</response>
        [ProducesResponseType(200)]
        public override Task<long> Create([FromBody] CarrierDto dto)
        {
            return _service.Create<Carrier>(dto);
        }

        /// <summary>
        /// Updates existing Carrier item.
        /// </summary>
        /// <param name="dto">Carrier DTO object.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Carrier item successfully updated.</response>
        /// <response code="404">If specified Carrier item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Update([FromBody] CarrierDto dto)
        {
            return _service.Update<Carrier>(dto);
        }

        /// <summary>
        /// Deletes specified by id Carrier item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Carrier item successfully deleted.</response>
        /// <response code="404">If specified Carrier item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Delete(long id)
        {
            return _service.Delete<Carrier>(id);
        }
    }
}