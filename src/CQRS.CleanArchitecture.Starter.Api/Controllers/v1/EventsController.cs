using CQRS.CleanArchitecture.Starter.Api.Utility;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Commands.CreateEvent;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Commands.DeleteEvent;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Commands.UpdateEvent;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventDetail;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<EventListVm>>> GetAllEvents()
        {
            var dtos = await _mediator.Send(new GetEventsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventDetailVm>> GetEventById(Guid id)
        {
            var getEventDetailQuery = new GetEventDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateEventCommand createEventCommand)
        {
            var id = await _mediator.Send(createEventCommand);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(UpdateEventCommand updateEventCommand)
        {
            await _mediator.Send(updateEventCommand);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteEventCommand = new DeleteEventCommand() { EventId = id };
            await _mediator.Send(deleteEventCommand);
            return NoContent();
        }

        [HttpGet("export")]
        [FileResultContentType("text/csv")]
        public async Task<FileResult> ExportEvents()
        {
            var fileDto = await _mediator.Send(new GetEventsExportQuery());

            return File(fileDto.Data, fileDto.ContentType, fileDto.EventExportFileName);
        }
    }
}
