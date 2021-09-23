using CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Persistence;
using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using CQRS.CleanArchitecture.Starter.Infrastructure.Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Infrastructure.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(CqrsStarterDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches =  _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }
    }
}
