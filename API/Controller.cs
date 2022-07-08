using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Services;
using Entities;

namespace API
{
    /// <summary>
    /// Base controller.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    /// <typeparam name="TDto">Entity Dto.</typeparam>
    public abstract class Controller<TEntity, TDto> : ControllerBase where TEntity : BaseEntity where TDto : BaseDto
    {
        /// <summary>
        /// Creates IService object.
        /// </summary>
        public readonly IService<TEntity, TDto> _service;

        /// <summary>
        /// Creates Controller object.
        /// </summary>
        /// <param name="service">IService object.</param>
        public Controller(IService<TEntity,TDto> service)
        {
            _service = service;
        }

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <returns>List of items.</returns>
        [HttpGet]
        public abstract Task<List<TDto>> Get();

        /// <summary>
        /// Gets specified by id item.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Entity DTO object.</returns>
        [HttpGet("{id:long}")]
        public abstract Task<TDto> GetById(long id);

        /// <summary>
        /// Creates new item in database.
        /// </summary>
        /// <param name="dto">Entity DTO object.</param>
        /// <returns>Created item id.</returns>
        [HttpPost]
        public abstract Task<long> Create([FromBody] TDto dto);

        /// <summary>
        /// Updates existing item.
        /// </summary>
        /// <param name="dto">Entity DTO object.</param>
        /// <returns>Void.</returns>
        [HttpPut]
        public abstract Task Update([FromBody] TDto dto);

        /// <summary>
        /// Deletes specified by id item.
        /// </summary>
        /// <param name="id">Item id.</param>
        /// <returns>Void.</returns>
        [HttpDelete("{id:long}")]
        public abstract Task Delete(long id);
    }
}
