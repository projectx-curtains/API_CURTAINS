using Microsoft.AspNetCore.Mvc;
using Curtains.Domain.Projections;
using Curtains.Application.DTO;
using Curtains.Application.SearchService.Interfaces;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Api.Controllers
{
	/// <summary>
	/// This controller <c> FiltersCurtainsController </c> for indexes 
    /// and searchind data from ElastiSearch 
	/// </summary>
	[Route("api/[controller]")]
    [ApiController]
    public class FiltersCurtainsController : ControllerBase
    {
        private readonly ICurtainSearchService _searchService;

        public FiltersCurtainsController(ICurtainSearchService searchService)
        {
            _searchService = searchService;
        }

		/// <summary>
        /// This method handles requests and indexes data to ElastiSearch from database
        /// </summary>
        /// <returns></returns>
        [Route("IndexForElastic")]
		[HttpGet]
        public async Task<ActionResult> AddAllIndexes()
        {
            await _searchService.AddAllCurtains();
            return Ok();
        }

		/// <summary>
		/// This method handles requests and get all curtains from database
		/// </summary>
		/// <returns></returns>
		[Route("GetCurtainsFromDB")]
        [HttpGet]
        public ActionResult GetCurtains()
        {
            var x = _searchService.GetAllCurtains();
            return Ok(x);
        }

		/// <summary>
		/// This method handles requests and applies search filters for curtains from ElasticSearch
		/// </summary>
		/// <param name="request"> Seatch query </param>
		/// <returns> Http status code 200 </returns>
		[Route("CurtainsSearch")]
        [HttpPost]
        public async Task<ActionResult<List<SearchResults<CurtainsProjection>>>> CurtainSearch([FromQuery] ElasticSearchQuery<CurtainSearchDTO> request)
        {
            var response = await _searchService.CurtainsSearch(request);
            return Ok(response);
        }
    }
}