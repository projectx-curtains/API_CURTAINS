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
    /// This controller <c> CurtainsController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CurtainsController : ControllerBase
    {
        private readonly ICurtainsService _curtainsService;

        public CurtainsController(ICurtainsService curtainsService)
        {
            _curtainsService = curtainsService;
        }

        /// <summary>
        /// This method handles requests and get all curtains from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<CurtainsDTO>> GetAll()
        {
            var model = _curtainsService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get curtains from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid curtains entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CurtainsDTO>> GetById(int id)
        {
            var model = await _curtainsService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(CurtainsDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _curtainsService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(CurtainsDTO entity)
        {
            if (entity != null)
            {
                await _curtainsService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(CurtainsDTO entity)
        {
            if (entity != null)
            {
                await _curtainsService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
