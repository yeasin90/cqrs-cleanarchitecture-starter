using CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Persistence;
using CQRS.CleanArchitecture.Starter.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.CleanArchitecture.Starter.Infrastructure.Persistence
{
    public static class InfrastrcuturePersistenceRegistration
    {
        public static IServiceCollection AddInfrastrcuturePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CqrsStarterDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CqrsStarterConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
