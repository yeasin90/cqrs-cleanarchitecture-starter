using MediatR;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery: IRequest<EventExportFileVm>
    {
    }
}
