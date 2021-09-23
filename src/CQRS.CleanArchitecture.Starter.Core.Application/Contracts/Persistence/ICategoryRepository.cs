using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
