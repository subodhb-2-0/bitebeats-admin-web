using BiteBeats.Core.Infrastructure.Dependency;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BiteBeats.Core.Services.Dependency;

namespace BiteBeats.Core.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAllDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddServices()
                .AddInfrastructure(configuration);
            return services;
        }
    }
}