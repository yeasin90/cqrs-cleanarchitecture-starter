# CQRS CleanArchitecture Starter
A simple project to understand how CQRS pattern works with CleanArchitecture. Some basic CRUD operations has been implements using CQRS-CleanArchitecture. Each operation has been exposed as a REST API end pointsfrom controllers. Every project in this solution was created with ASP.NET Core 3.1 Empty Template. Sql Server localDB has been used with EF-Core for database, so you don't need to install any Sql server separately. 

Features:

### How to run the project:
- Clone and build the repo
- Set **CQRS.CleanArchitecture.Starter.Infrastructure.Persistence** as startup project
- Open Package manager console, create database with command: **update-database**
- Set **CQRS.CleanArchitecture.Starter.Api** as startup project
- Run the project. 
- Hit https://localhost:5001/swagger to see the api endpoints 

### Example endpoints:
Category: 
- https://localhost:5001/api/v1/category/all
- https://localhost:5001/api/v1/category/allwithevents
- https://localhost:5001/api/v1/category (POST)

Events: 
- https://localhost:5001/api/v1/events/all
- https://localhost:5001/api/v1/events/{id} (GET)

### Nugets used:
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

### Remove exisitng migrations: 
https://stackoverflow.com/a/50657539/2672014
