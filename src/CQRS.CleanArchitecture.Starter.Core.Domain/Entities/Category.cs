using CQRS.CleanArchitecture.Starter.Core.Domain.Common;
using System;
using System.Collections.Generic;

namespace CQRS.CleanArchitecture.Starter.Core.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
