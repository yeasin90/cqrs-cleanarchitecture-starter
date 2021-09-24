using MediatR;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommand: IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}
