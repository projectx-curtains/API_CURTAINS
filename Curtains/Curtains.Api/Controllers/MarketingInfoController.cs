using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// This controller <c> MarketingInfoController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingInfoController : ControllerBase
    {
        private readonly IMarketingInfoService _marketingInfoService;

        public MarketingInfoController(IMarketingInfoService marketingInfoService)
        {
            _marketingInfoService = marketingInfoService;
        }

        /// <summary>
        /// This method handles requests and get all marketing info from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<MarketingInfoDTO>> GetAll()
        {
            var model = _marketingInfoService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get marketing info from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid marketing info entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MarketingInfoDTO>> GetById(int id)
        {
            var model = await _marketingInfoService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds Marketing info to database.
        /// </summary>
        /// <param name="entity"> MarketingInfoDTO marketing info </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(MarketingInfoDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _marketingInfoService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(MarketingInfoDTO entity)
        {
            if (entity != null)
            {
                await _marketingInfoService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(MarketingInfoDTO entity)
        {
            if (entity != null)
            {
                await _marketingInfoService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
