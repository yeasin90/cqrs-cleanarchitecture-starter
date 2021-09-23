using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRS.CleanArchitecture.Starter.Infrastructure.Persistence.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(e => e.CreatedDate)
                   .HasDefaultValueSql("getutcdate()");
        }
    }
}
