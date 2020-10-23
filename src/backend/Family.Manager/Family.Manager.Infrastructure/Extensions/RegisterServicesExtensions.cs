using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.DataProviders.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Family.Manager.Infrastructure.Extensions
{
    public static class RegisterServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<BusinessLogicData>();
            services.AddTransient<IRepositoryBase<Kid, Guid>, KidRepository>();
        }
    }
}
