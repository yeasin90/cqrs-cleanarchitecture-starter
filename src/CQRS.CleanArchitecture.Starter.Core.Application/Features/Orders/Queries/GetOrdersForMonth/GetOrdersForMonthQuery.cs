using MediatR;
using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Orders.Queries.GetOrdersForMonth
{
    public class GetOrdersForMonthQuery : IRequest<PagedOrdersForMonthVm>
    {
        public DateTime Date { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
