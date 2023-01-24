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
    /// This controller <c> CurtainsTypeController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CurtainsTypeController : ControllerBase
    {
        private readonly ICurtainsTypeService _curtainsTypeService;

        public CurtainsTypeController(ICurtainsTypeService curtainsTypeService)
        {
            _curtainsTypeService = curtainsTypeService;
        }

        /// <summary>
        /// This method handles requests and get all curtains type from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<CurtainsTypeDTO>> GetAll()
        {
            var model = _curtainsTypeService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get curtains type from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid curtains type entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CurtainsTypeDTO>> GetById(int id)
        {
            var model = await _curtainsTypeService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(CurtainsTypeDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _curtainsTypeService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(CurtainsTypeDTO entity)
        {
            if (entity != null)
            {
                await _curtainsTypeService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(CurtainsTypeDTO entity)
        {
            if (entity != null)
            {
                await _curtainsTypeService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
