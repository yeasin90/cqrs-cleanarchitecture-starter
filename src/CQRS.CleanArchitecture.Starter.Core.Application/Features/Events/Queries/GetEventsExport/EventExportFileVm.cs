namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport
{
    public class EventExportFileVm
    {
        public string EventExportFileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}