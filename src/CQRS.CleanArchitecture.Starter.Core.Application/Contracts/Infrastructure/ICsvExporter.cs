using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
