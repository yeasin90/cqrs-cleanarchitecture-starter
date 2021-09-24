using AutoMapper;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Commands.CreateCateogry;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Queries.GetCategoriesList;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Commands.CreateEvent;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Commands.UpdateEvent;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventDetail;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsList;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Orders.Queries.GetOrdersForMonth;
using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
