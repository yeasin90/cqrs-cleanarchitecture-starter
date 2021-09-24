﻿using AutoMapper;
using CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Infrastructure;
using CQRS.CleanArchitecture.Starter.Core.Application.Contracts.Persistence;
using CQRS.CleanArchitecture.Starter.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQueryHandler : IRequestHandler<GetEventsExportQuery, EventExportFileVm>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;
        private readonly ICsvExporter _csvExporter;

        public GetEventsExportQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository, ICsvExporter csvExporter)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _csvExporter = csvExporter;
        }

        public async Task<EventExportFileVm> Handle(GetEventsExportQuery request, CancellationToken cancellationToken)
        {
            var allEvents = _mapper.Map<List<EventExportDto>>((await _eventRepository.ListAllAsync()).OrderBy(x => x.Date));

            var fileData = _csvExporter.ExportEventsToCsv(allEvents);

            var eventExportFileDto = new EventExportFileVm() { ContentType = "text/csv", Data = fileData, EventExportFileName = $"{Guid.NewGuid()}.csv" };

            return eventExportFileDto;
        }
    }
}
