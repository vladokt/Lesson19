using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using Entities;
using DB;

namespace Services
{
    /// <summary>
    /// Base service.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    /// <typeparam name="TDto">Entity DTO type.</typeparam>
    public class Service<TEntity, TDto> : IService<TEntity, TDto> where TEntity : BaseEntity where TDto : BaseDto
    {
        /// <summary>
        /// AppDbContext object.
        /// </summary>
        protected readonly AppDbContext _context;

        /// <summary>
        /// IBaseMapper object.
        /// </summary>
        protected readonly IBaseMapper _mapper;

        /// <summary>
        /// Creates Service object.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public Service(AppDbContext context, IBaseMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>
        /// Gets all items from database.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <returns>List of entities.</returns>
        public Task<List<TDto>> Get<T>() where T : BaseEntity
        {
            return _context.Set<T>().ProjectTo<TDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        /// <summary>
        /// Gets specified by id item from database.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="id">Id.</param>
        /// <returns>Entity.</returns>
        /// <exception cref="IndexOutOfRangeException"> if specified item does not exist.</exception>
        public Task<TDto> GetById<T>(long id) where T : BaseEntity
        {
            var entity = _context.Set<T>().ProjectTo<TDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
            
            if (entity.Result == default)
            {
                throw new IndexOutOfRangeException();
            }

            return entity!;
        }

        /// <summary>
        /// Creates new item in database.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="dto">Entity DTO</param>
        /// <returns>Created item id.</returns>
        public async Task<long> Create<T>(TDto dto) where T : BaseEntity
        {
            var entity = _mapper.Map<T>(dto);
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        /// <summary>
        /// Updates existing item in database.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="dto">Entity DTO.</param>
        /// <returns>Void.</returns>
        /// <exception cref="IndexOutOfRangeException"> if specified item does not exist.</exception>
        public async Task Update<T>(TDto dto) where T : BaseEntity
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (entity == default)
            {
                throw new IndexOutOfRangeException();
            }
            _mapper.Map(dto, entity);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes specified by id item from database.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="id">Entity id.</param>
        /// <returns>Void.</returns>
        /// <exception cref="IndexOutOfRangeException"> if specified entitem does not exist.</exception>
        public async Task Delete<T>(long id) where T : BaseEntity
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (entity == default)
            {
                throw new IndexOutOfRangeException();
            }

            _context.Set<T>().Remove(entity!);

            await _context.SaveChangesAsync();
        }
    }
}
