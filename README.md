# CQRS CleanArchitecture Starter
Every project in this solution was created with ASP.NET Core 3.1 Empty Template

### Nugets:
- AutoMapper
- AutoMapper.Extensions.Microsoft.DependencyInjection
- FluentValidation
- FluentValidation.DependencyInjectionExtensions
- MediatR 
- MediatR.Extensions.Microsoft.Dependency 
- Microsoft.AspNetCore.Mvc.Versioning
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.Extensions.DependencyInjection
- Microsoft.Extensions.Logging
- Microsoft.Extensions.Logging.Abstractions
- Microsoft.Extensions.Options.ConfigurationExtension
- SendGrid
- CsvHelper
- Swashbuckle.AspNetCore
- Swashbuckle.AspNetCore.Swagger

### Example endpoints:
Category: 
- https://localhost:5001/api/v1/category/all
- https://localhost:5001/api/v1/category/allwithevents
- https://localhost:5001/api/v1/category (POST)

Events: 
- https://localhost:5001/api/v1/events/all
- https://localhost:5001/api/v1/events/{id} (GET)

### Remove exisitng migrations: 
https://stackoverflow.com/a/50657539/2672014
