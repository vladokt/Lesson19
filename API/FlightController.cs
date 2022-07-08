using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API
{
    /// <summary>
    /// Flight controller.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class FlightController : Controller<Flight, FlightDto>
    {
        /// <summary>
        /// Creates FlightController object.
        /// </summary>
        /// <param name="service">IFlightService object.</param>
        public FlightController(IFlightService service) : base(service)
        {
        }

        /// <summary>
        /// Gets all Flight items from database.
        /// </summary>
        /// <returns>List of items.</returns>
        /// <response code="200">Return the list of Flight items.</response>
        [ProducesResponseType(200)]
        public override Task<List<FlightDto>> Get()
        {
            return _service.Get<Flight>();
        }

        /// <summary>
        /// Gets specified by id Flight item.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Flight DTO object.</returns>
        /// <response code="200">Return specified by id Flight item.</response>
        /// <response code="404">If specified Flight item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task<FlightDto> GetById(long id)
        {
            return _service.GetById<Flight>(id);
        }

        /// <summary>
        /// Creates new Flight item in database.
        /// </summary>
        /// <param name="dto">Flight DTO object.</param>
        /// <returns>Created item id.</returns>
        /// <response code="200">Return the created Flight item id.</response>
        [ProducesResponseType(200)]
        public override Task<long> Create([FromBody] FlightDto dto)
        {
            return _service.Create<Flight>(dto);
        }

        /// <summary>
        /// Updates existing Flight item.
        /// </summary>
        /// <param name="dto">Flight DTO object.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Flight item successfully updated.</response>
        /// <response code="404">If specified Flight item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Update([FromBody] FlightDto dto)
        {
            return _service.Update<Flight>(dto);
        }

        /// <summary>
        /// Deletes specified by id Flight item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Flight item successfully deleted.</response>
        /// <response code="404">If specified Flight item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Delete(long id)
        {
            return _service.Delete<Flight>(id);
        }
    }
}