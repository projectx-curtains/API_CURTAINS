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
		[Route("Index")]
		[HttpGet]
        public async Task<ActionResult> AddAllCurtains()
        {
            await _searchService.IndexesCurtains();
            return Ok();
        }

		/// <summary>
		/// This method handles requests and delete curtain from ElasticSearch by entity Id.
		/// </summary>
		/// <param name="id"> Id curtain identifier </param>
		/// <returns></returns>
		[Route("Delete")]
		[HttpGet]
        public async Task<ActionResult> DeleteCurtain(string id)
        {
            await _searchService.DeleteCurtain(id);
            return Ok();
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