using BiteBeats.Core.Infrastructure.Implementations;
using BiteBeats.Core.Infrastructure.Persistence;
using BiteBeats.Core.Interfaces.Interfaces.Base;
using BiteBeats.Core.Interfaces.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BiteBeats.Core.Infrastructure.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistence(configuration);
            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BiteBeatsDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                );
            services.AddScoped<IUnitOfWorkService, UnitOfWorkRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            return services;
        }
    }
}
