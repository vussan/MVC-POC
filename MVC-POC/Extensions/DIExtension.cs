using Core;
using Persistence;

namespace MVC_POC.Extensions
{
    public static class DIExtension
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
