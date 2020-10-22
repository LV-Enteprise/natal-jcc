using Microsoft.Extensions.DependencyInjection;

namespace Family.Manager.Infrastructure.Extensions
{
    public static class RegisterServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<BusinessLogicData>();
        }
    }
}
