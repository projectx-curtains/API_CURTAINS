using Microsoft.AspNetCore.Mvc;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ActionResult<IEnumerable<CurtainsModel>> Post(CurtainsModel model, string indexName)
        {
            var response = _elastic.Index(model, indexName);
            return Ok(response);
        }
    }
}
