using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
    }
}
