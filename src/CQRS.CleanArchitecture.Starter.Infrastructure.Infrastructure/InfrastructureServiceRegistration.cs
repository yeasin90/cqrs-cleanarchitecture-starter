using CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Infrastructure;
using CQRS.CleanArchitecture.Starter.Core.Application.Models.Mail;
using CQRS.CleanArchitecture.Starter.Infrastructure.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.CleanArchitecture.Starter.Infrastructure.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
