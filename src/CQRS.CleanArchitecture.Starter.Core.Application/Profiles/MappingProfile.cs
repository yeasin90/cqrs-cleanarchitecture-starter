using AutoMapper;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Commands.CreateCateogry;
using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
        }
    }
}
