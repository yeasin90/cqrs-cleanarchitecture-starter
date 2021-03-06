using CQRS.CleanArchitecture.Starter.Core.Domain.Common;
using System;

namespace CQRS.CleanArchitecture.Starter.Core.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
