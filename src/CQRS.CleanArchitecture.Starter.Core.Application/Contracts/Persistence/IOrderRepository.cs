using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Persistence
{
    public interface IOrderRepository: IAsyncRepository<Order>
    {
        Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size);
        Task<int> GetTotalCountOfOrdersForMonth(DateTime date);
    }
}
