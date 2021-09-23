using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
