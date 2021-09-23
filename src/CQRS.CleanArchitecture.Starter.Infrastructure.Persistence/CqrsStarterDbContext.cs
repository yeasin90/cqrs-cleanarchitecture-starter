using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.CleanArchitecture.Starter.Infrastructure.Persistence
{
    public class CqrsStarterDbContext : DbContext
    {
        public CqrsStarterDbContext(DbContextOptions<CqrsStarterDbContext> options)
           : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
