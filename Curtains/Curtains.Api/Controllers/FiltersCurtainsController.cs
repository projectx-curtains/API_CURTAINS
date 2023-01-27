using Microsoft.AspNetCore.Mvc;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Domain.Projections;
using Curtains.Application.DTO;
using Curtains.Application.SearchService.Interfaces;
using Curtains.Infrastructure.SearchQueries;
using MediatR;

namespace Curtains.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersCurtainsController : ControllerBase
    {
        private readonly ICurtainSearchService _searchService;
        private readonly IMediator _mediator;

        public FiltersCurtainsController(
            ICurtainSearchService searchService,
            IMediator mediator)
        {
            _searchService = searchService;
            _mediator = mediator;
        }

		[Route("IndexForElastic")]
		[HttpGet]
        public async Task<ActionResult> AddAllIndexes()
        {
            await _searchService.AddAllCurtains();
            return Ok();
        }

        [Route("GetCurtainsFromDB")]
        [HttpGet]
        public ActionResult GetCurtains()
        {
            var x = _searchService.GetAllCurtains();
            return Ok(x);
        }
        
        [Route("CurtainsSearch")]
        [HttpPost]
        public async Task<ActionResult<List<SearchResults<CurtainsProjection>>>> CurtainSearch([FromQuery] ElasticSearchQuery<CurtainSearchDTO> request)
        {
            var response = await _searchService.CurtainsSearch(request);
            return Ok(response);
        }
    }
}