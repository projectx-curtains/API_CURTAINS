using Microsoft.AspNetCore.Mvc;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Domain.Projections;

namespace Curtains.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersCurtainsController : ControllerBase
    {
        private readonly IElasticCurtainsIndexRepository _elastic;

        public FiltersCurtainsController(IElasticCurtainsIndexRepository elastic)
        {
            _elastic = elastic;
        }

        [HttpPost]
        public ActionResult<IEnumerable<CurtainsModel>> AddIndex(CurtainsProjection model, string indexName)
        {
            var response = _elastic.Index(model, indexName);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteIndex(CurtainsProjection model, string indexName)
        {
            var response = _elastic.Delete(model, indexName);
            return Ok();
        }
    }
}
