using Entities;

namespace Services
{
    /// <summary>
    /// Base service interface.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    /// <typeparam name="TDto">Entity DTO type.</typeparam>
    public interface IService<TEntity, TDto> where TEntity : BaseEntity where TDto : BaseDto
    {
        /// <summary>
        /// Gets all items from database.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<List<TDto>> Get<T>() where T : BaseEntity;

        /// <summary>
        /// Gets specified by id item.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="id">Item id.</param>
        /// <returns>Entity DTO object.</returns>
        public Task<TDto> GetById<T>(long id) where T : BaseEntity;

        /// <summary>
        /// Creates new item in database.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="dto">Entity DTO object.</param>
        /// <returns>Created item id.</returns>
        public Task<long> Create<T>(TDto dto) where T : BaseEntity;

        /// <summary>
        /// Updates existing item in database.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="dto">Entity DTO object.</param>
        /// <returns>Void.</returns>
        public Task Update<T>(TDto dto) where T : BaseEntity;

        /// <summary>
        /// Deletes specified by id item.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="id">Item id.</param>
        /// <returns>Void.s</returns>
        public Task Delete<T>(long id) where T : BaseEntity;
    }
}
