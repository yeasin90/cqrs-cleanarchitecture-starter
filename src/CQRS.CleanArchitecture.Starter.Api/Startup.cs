using CQRS.CleanArchitecture.Starter.Core.Application;
using CQRS.CleanArchitecture.Starter.Infrastructure.Infrastructure;
using CQRS.CleanArchitecture.Starter.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using CQRS.CleanArchitecture.Starter.Api.Utility;
using CQRS.CleanArchitecture.Starter.Api.Middleware;

namespace CQRS.CleanArchitecture.Starter.Api
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
            AddSwagger(services);
            AddApiVersioning(services);

            services.AddApplicationServices();
            services.AddInfrastrcuturePersistenceServices(Configuration);
            services.AddInfrastructureServices(Configuration);

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            }); 
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "CQRS Starter"
                });

                c.OperationFilter<FileResultContentTypeOperationFilter>();
            });
        }

        private void AddApiVersioning(IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                // Specify the default API Version as 1.0
                config.DefaultApiVersion = new ApiVersion(1, 0);
                // If the client hasn't specified the API version in the request, use the default API version number 
                config.AssumeDefaultVersionWhenUnspecified = true;
                // Advertise the API versions supported for the particular endpoint
                config.ReportApiVersions = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Check: https://www.appmarq.com/public/security,1043066,Always-use-HTTPS-Redirection-Middleware-and-HSTS-Middleware-in-your-ASPNET-Core-application
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CQRS Starter");
            });
            app.UseCustomExceptionHandler();
            app.UseCors("Open");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
