using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Queries.GetCategoriesList
{
    public class CategoryListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
