using CQRS.CleanArchitecture.Starter.Core.Application.Responses;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse: BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {

        }

        public CreateCategoryDto Category { get; set; }
    }
}