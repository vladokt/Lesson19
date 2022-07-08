using AutoMapper;

namespace Services
{
    /// <summary>
    /// Base mapper interface.
    /// </summary>
    public interface IBaseMapper
    {
        /// <summary>
        /// Mapper configuration provider.
        /// </summary>
        public IConfigurationProvider ConfigurationProvider { get; }

        /// <summary>
        /// Convert object to type <typeparamref name="T"/> object.
        /// </summary>
        /// <typeparam name="T">Destination type.</typeparam>
        /// <param name="source">Source object.</param>
        /// <returns>Destination type object.</returns>
        public T Map<T>(object source);

        /// <summary>
        /// Convert object to type <typeparamref name="TDestination"/> object.
        /// </summary>
        /// <typeparam name="TSource">Source type.</typeparam>
        /// <typeparam name="TDestination">Destination type.</typeparam>
        /// <param name="source">Source object.</param>
        /// <param name="destination">Destination object.</param>
        public void Map<TSource, TDestination>(TSource source, TDestination destination);
    }
}