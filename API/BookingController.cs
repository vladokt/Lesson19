using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API
{
    /// <summary>
    /// Booking controller.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class BookingController : Controller<Booking, BookingDto>
    {
        /// <summary>
        /// Creates BookingController object.
        /// </summary>
        /// <param name="service">IBookingService object.</param>
        public BookingController(IBookingService service) : base(service)
        {
        }

        /// <summary>
        /// Gets all Booking items from database.
        /// </summary>
        /// <returns>List of items.</returns>
        /// <response code="200">Return the list of Booking items.</response>
        [ProducesResponseType(200)]
        public override Task<List<BookingDto>> Get()
        {
            return _service.Get<Booking>();
        }

        /// <summary>
        /// Gets specified by id Booking item.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Booking DTO object.</returns>
        /// <response code="200">Return specified by id Booking item.</response>
        /// <response code="404">If specified Booking item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task<BookingDto> GetById(long id)
        {
            return _service.GetById<Booking>(id);
        }

        /// <summary>
        /// Creates new Booking item in database.
        /// </summary>
        /// <param name="dto">Booking DTO object.</param>
        /// <returns>Created item id.</returns>
        /// <response code="200">Return the created Booking item id.</response>
        [ProducesResponseType(200)]
        public override Task<long> Create([FromBody] BookingDto dto)
        {
            return _service.Create<Booking>(dto);
        }

        /// <summary>
        /// Updates existing Booking item.
        /// </summary>
        /// <param name="dto">Booking DTO object.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Booking item successfully updated.</response>
        /// <response code="404">If specified Booking item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Update([FromBody] BookingDto dto)
        {
            return _service.Update<Booking>(dto);
        }

        /// <summary>
        /// Deletes specified by id Booking item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Void.</returns>
        /// <response code="200">If specified Booking item successfully deleted.</response>
        /// <response code="404">If specified Booking item was not found.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public override Task Delete(long id)
        {
            return _service.Delete<Booking>(id);
        }
    }
}