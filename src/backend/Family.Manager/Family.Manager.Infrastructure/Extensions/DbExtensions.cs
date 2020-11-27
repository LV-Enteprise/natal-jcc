using Family.Manager.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Family.Manager.Infrastructure.Extensions
{
    public static class DbExtensions
    {
        public static void AddDbService(this IServiceCollection services, string connectionString)
        {
            //services.AddDbContext<FamilyContext>(opt => opt.UseNpgsql(connectionString));
            services.AddDbContext<FamilyContext>(opt => opt.UseInMemoryDatabase(connectionString));
        }
    }
}
