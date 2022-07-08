using AutoMapper;
using Entities;

namespace Services
{
    /// <summary>
    /// Creates BaseMapper object.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    /// <typeparam name="TDto">Entity DTO type.</typeparam>
    public class BaseMapper<TEntity, TDto> : IBaseMapper
    {
        /// <summary>
        /// Base mapper object.
        /// </summary>
        protected IMapper MapperObj { get; set; }

        /// <inheritdoc />
        public IConfigurationProvider ConfigurationProvider => MapperObj.ConfigurationProvider;

        /// <summary>
        /// Configure and creating mapper object.
        /// </summary>
        public BaseMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TDto>().ReverseMap());
            MapperObj = config.CreateMapper();
        }

        /// <inheritdoc />
        public T Map<T>(object source)
        {
            return MapperObj.Map<T>(source);
        }

        /// <inheritdoc />
        public void Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            MapperObj.Map(source, destination);
        }
    }
}