using JsonTestAPI.Core.Entities;
using JsonTestAPI.Core.Enum;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JsonTestAPI.Controllers
{
    [ApiController]
    [Route("json-data-test")]
    public class JsonDataTestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JsonDataTestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-json-data-test-1")]
        [ProducesResponseType(typeof(List<JsonDataTest1>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetJsonDataTest1(string filter, [FromHeader] string[] multipleFilters, FillerEnum fillerEnum, [FromHeader] FillerEnum[] multipleFiltersEnum)
        {
            var response = await _mediator.Send(new JsonData1.Command
            {
                Filter = filter,
                MultipleFilter = multipleFilters.ToList(),

                FilterEnum = fillerEnum,
                MultipleFilterEnum = multipleFiltersEnum.ToList()
            });

            return Ok(response);
        }

        [HttpGet("get-json-data-test-2")]
        [ProducesResponseType(typeof(List<JsonDataTest1>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetJsonDataTest2(string filter, [FromHeader] string[] multipleFilters, int filterInt, [FromHeader] int[] multipleFiltersInt, FillerEnum fillerEnum, [FromHeader] FillerEnum[] multipleFiltersEnum)
        {
            var response = await _mediator.Send(new JsonData2.Command
            {
                Filter = filter,
                MultipleFilter = multipleFilters.ToList(),

                FilterInt = filterInt,
                MultipleFilterInt = multipleFiltersInt.ToList(),

                FilterEnum = fillerEnum,
                MultipleFilterEnum = multipleFiltersEnum.ToList()
            });

            return Ok(response);
        }


        [HttpGet("get-json-data-test-2-query")]
        [ProducesResponseType(typeof(List<JsonDataTest1>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetJsonDataTest2Query(string filter, [FromHeader] string[] multipleFilters, FillerEnum fillerEnum, [FromHeader] FillerEnum[] multipleFiltersEnum)
        {
            var response = await _mediator.Send(new JsonData2Query.Command
            {
                Filter = filter,
                MultipleFilter = multipleFilters.ToList(),

                FilterEnum = fillerEnum,
                MultipleFilterEnum = multipleFiltersEnum.ToList()
            });

            return Ok(response);
        }
    }
}
