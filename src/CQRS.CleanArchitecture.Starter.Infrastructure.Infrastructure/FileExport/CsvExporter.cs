using CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Infrastructure;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport;
using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CQRS.CleanArchitecture.Starter.Infrastructure.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
