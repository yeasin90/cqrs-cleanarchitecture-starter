using MediatR;
using System.Collections.Generic;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
