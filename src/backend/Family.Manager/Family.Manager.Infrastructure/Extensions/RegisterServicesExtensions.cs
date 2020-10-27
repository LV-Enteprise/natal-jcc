using Family.Manager.Infrastructure.DataProviders.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Family.Manager.Infrastructure.Extensions
{
    public static class RegisterServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IFamilyRepository, FamilyRepository>();
            services.AddTransient<IKinshipRepository, KinshipRepository>();
            services.AddTransient<IKidRepository, KidRepository>();
            services.AddTransient<IKidReligionInformationRepository, KidReligionInformationRepository>();
        }
    }
}
