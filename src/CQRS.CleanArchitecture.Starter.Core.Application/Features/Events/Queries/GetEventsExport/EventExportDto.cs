using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport
{
    public class EventExportDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
