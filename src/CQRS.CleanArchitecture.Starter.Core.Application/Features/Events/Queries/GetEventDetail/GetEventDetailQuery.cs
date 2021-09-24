using MediatR;
using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery: IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
