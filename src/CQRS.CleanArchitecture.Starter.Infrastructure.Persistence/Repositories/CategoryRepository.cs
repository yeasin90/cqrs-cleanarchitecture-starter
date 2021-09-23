using CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Persistence;
using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using CQRS.CleanArchitecture.Starter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CqrsStarterDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
            var allCategories = await _dbContext.Categories.Include(x => x.Events).ToListAsync();
            if(!includePassedEvents)
            {
                allCategories.ForEach(p => p.Events.ToList().RemoveAll(c => c.Date < DateTime.Today));
            }
            return allCategories;
        }
    }
}
