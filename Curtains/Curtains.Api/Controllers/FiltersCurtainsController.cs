using Microsoft.AspNetCore.Mvc;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Domain.Projections;
using Curtains.Application.DTO;
using Curtains.Application.SearchService.Interfaces;

namespace Curtains.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersCurtainsController : ControllerBase
    {
        private readonly IElasticCurtainsIndexRepository _elastic;
        private readonly ICurtainSearchService _searchService;

        public FiltersCurtainsController(IElasticCurtainsIndexRepository elastic, ICurtainSearchService searchService)
        {
            _elastic = elastic;
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<ActionResult> AddAllIndexes(string indexName)
        {
            await _searchService.AddAllCurtains(indexName);
            return Ok();
        }
        
        [HttpPost]
        public ActionResult<IEnumerable<CurtainsModel>> AddIndex(CurtainsProjection model, string indexName)
        {
            var response = _elastic.Index(model, indexName);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteIndex(string id, string indexName)
        {
            var response = _elastic.Deleted(id, indexName);
            return Ok();
        }
        [Route("CurtainsSearch")]
        [HttpPost]
        public async Task<ActionResult> CurtainSearch([FromQuery] CurtainsDTO modelDTO, string indexName)
        {
            var response = await _searchService.CurtainsSearch(modelDTO, indexName);
            return Ok(response);
        }
    }
}
