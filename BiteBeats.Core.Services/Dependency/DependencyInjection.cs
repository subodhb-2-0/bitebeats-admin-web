using BiteBeats.Core.Interfaces.Interfaces.Repository;
using BiteBeats.Core.Interfaces.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;


namespace BiteBeats.Core.Services.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRestaurantService, RestaurantService>();
            return services;
        }
    }
}
