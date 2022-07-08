using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API
{
    /// <summary>
    /// Passenger controller.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class PassengerController : Controller<Passenger, PassengerDto>
    {
        /// <summary>
        /// Creates PassengerController object.
        /// </summary>
        /// <param name="service">IPassengerService object.</param>
        public PassengerController(IPassengerService service) : base(service)
        {    
        }

        /// <summary>
        /// Gets all Passenger items from database.
        /// </summary>
        /// <returns>List of items.</returns>
        /// <response code="200">Return the list of Passenger items.</response>
        [ProducesResponseType(200)]
        public override Task<List<PassengerDto>> Get()
        {
            return _service.Get<Passenger>();
        }

        /// <summary>
        /// Gets specified by id Passenger item.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Passenger DTO object.</returns>
        /// <response code="200">Return specified by id Passenger item.</response>
        /// <response code="404">If specified Passenger item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task<PassengerDto> GetById(long id)
        {
            return _service.GetById<Passenger>(id);
        }

        /// <summary>
        /// Creates new Passenger item in database.
        /// </summary>
        /// <param name="dto">Passenger DTO object.</param>
        /// <returns>Created item id.</returns>
        /// <response code="200">Return the created Passenger item id.</response>
        [ProducesResponseType(200)]
        public override Task<long> Create([FromBody] PassengerDto dto)
        {
            return _service.Create<Passenger>(dto);
        }

        /// <summary>
        /// Updates existing Passenger item.
        /// </summary>
        /// <param name="dto">Passenger DTO object.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Passenger item successfully updated.</response>
        /// <response code="404">If specified Passenger item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Update([FromBody] PassengerDto dto)
        {
            return _service.Update<Passenger>(dto);
        }

        /// <summary>
        /// Deletes specified by id Passenger item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Passenger item successfully deleted.</response>
        /// <response code="404">If specified Passenger item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Delete(long id)
        {
            return _service.Delete<Passenger>(id);
        }
    }
}
