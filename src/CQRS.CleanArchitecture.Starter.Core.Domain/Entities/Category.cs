using System;
using System.Collections.Generic;

namespace CQRS.CleanArchitecture.Starter.Core.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
