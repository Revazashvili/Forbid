using Microsoft.Extensions.DependencyInjection;

namespace Forbids
{
    /// <summary>
    /// Extension class for <see cref="IServiceCollection"/> interface.
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Add <see cref="IForbid"/> in DI Container.
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <param name="serviceLifetime"><see cref="ServiceLifetime"/></param>
        /// <returns>A reference to the same <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddForbids(this IServiceCollection services,
            ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
        {
            var forbidServiceDescriptor = new ServiceDescriptor(typeof(IForbid), typeof(Forbid), serviceLifetime);
            services.Add(forbidServiceDescriptor);
            return services;
        }
    }
}