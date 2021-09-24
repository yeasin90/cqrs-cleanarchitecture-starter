using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Orders.Queries.GetOrdersForMonth
{
    public class OrdersForMonthDto
    {
        public Guid Id { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}