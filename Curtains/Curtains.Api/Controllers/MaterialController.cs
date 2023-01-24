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
    /// This controller <c> MaterialController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _materialService;

        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        /// <summary>
        /// This method handles requests and get all material from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<MaterialDTO>> GetAll()
        {
            var model = _materialService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get material from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid material entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MaterialDTO>> GetById(int id)
        {
            var model = await _materialService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds Material to database.
        /// </summary>
        /// <param name="entity"> MaterialDTO material </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(MaterialDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _materialService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(MaterialDTO entity)
        {
            if (entity != null)
            {
                await _materialService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(MaterialDTO entity)
        {
            if (entity != null)
            {
                await _materialService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
