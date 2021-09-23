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
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(CqrsStarterDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size)
        {
            return await _dbContext.Orders.Where(x => x.OrderPlaced.Month == date.Month && x.OrderPlaced.Year == date.Year)
                .Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<int> GetTotalCountOfOrdersForMonth(DateTime date)
        {
            return await _dbContext.Orders.CountAsync(x => x.OrderPlaced.Month == date.Month && x.OrderPlaced.Year == date.Year);
        }
    }
}
