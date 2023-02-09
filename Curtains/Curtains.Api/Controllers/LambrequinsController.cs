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
    /// This controller <c> LambrequinsController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LambrequinsController : ControllerBase
    {
        private readonly ILambrequinsService _lambrequinsService;

        public LambrequinsController(ILambrequinsService lambrequinsService)
        {
            _lambrequinsService = lambrequinsService;
        }

        /// <summary>
        /// This method handles requests and get all lambrequins from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<LambrequinsDTO>> GetAll()
        {
            var model = _lambrequinsService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get lambrequins from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid lambrequins entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<LambrequinsDTO>> GetById(int id)
        {
            var model = await _lambrequinsService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(LambrequinsDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _lambrequinsService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(LambrequinsDTO entity)
        {
            if (entity != null)
            {
                await _lambrequinsService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(LambrequinsDTO entity)
        {
            if (entity != null)
            {
                await _lambrequinsService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
