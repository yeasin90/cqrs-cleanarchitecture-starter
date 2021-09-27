using CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Commands.CreateCateogry;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Queries.GetCategoriesList;
using CQRS.CleanArchitecture.Starter.Core.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.CleanArchitecture.Starter.Api.Controllers.v1
{
    /// <summary>
    /// More about API routing verbs: https://www.c-sharpcorner.com/article/routing-in-restful-apis-using-net-core/
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<CategoryListVm>>> GetAllCategories()
        {
            var dtos = await _mediator.Send(new GetCategoriesListQuery());
            return Ok(dtos);
        }

        [HttpGet("allwithevents")]
        public async Task<ActionResult<List<CategoryEventListVm>>> GetCategoriesWithEvents(bool includeHistory)
        {
            GetCategoriesListWithEventsQuery getCategoriesListWithEventsQuery = new GetCategoriesListWithEventsQuery() { IncludeHistory = includeHistory };

            var dtos = await _mediator.Send(getCategoriesListWithEventsQuery);
            return Ok(dtos);
        }

        [HttpPost]
        public async Task<ActionResult<CreateCategoryCommandResponse>> Create([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}
