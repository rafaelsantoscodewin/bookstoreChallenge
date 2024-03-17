using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace bookstoreChallenge.business.Core.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
