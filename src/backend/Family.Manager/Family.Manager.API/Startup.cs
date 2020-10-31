using AutoMapper;
using Family.Manager.Infrastructure.Configurations.JsonSettings;
using Family.Manager.Infrastructure.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

namespace Family.Manager.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbService(Configuration.GetConnectionString("FamilyDb"));
            services.RegisterSwagger();
            services.RegisterServices();
            services.AddAutoMapper(typeof(Startup));
            services.AddGlobalExceptionHandlerMiddleware();
            services.AddControllers()
               .AddJsonOptions(options =>
               {
                   options.JsonSerializerOptions.PropertyNamingPolicy = new CustomPropertyNamingPolicy();
                   options.JsonSerializerOptions.IgnoreNullValues = true;
                   options.JsonSerializerOptions.WriteIndented = false;
                   options.JsonSerializerOptions.AllowTrailingCommas = false;
                   options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
               });
               //.AddNewtonsoftJson(options =>
               //{
               //    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
               //});
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseGlobalExceptionHandlerMiddleware();
            }

            app.UseHttpsRedirection();
            app.UseSwaggerConfigurations();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
