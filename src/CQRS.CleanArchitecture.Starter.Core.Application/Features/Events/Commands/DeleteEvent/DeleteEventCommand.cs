using MediatR;
using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand: IRequest
    {
        public Guid EventId { get; set; }
    }
}
