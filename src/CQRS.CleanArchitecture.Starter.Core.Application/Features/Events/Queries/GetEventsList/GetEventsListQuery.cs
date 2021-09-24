using MediatR;
using System.Collections.Generic;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {

    }
}
