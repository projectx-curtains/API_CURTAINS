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
    /// This controller <c> DecorationsController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DecorationsController : ControllerBase
    {
        private readonly IDecorationsService _decorationsService;

        public DecorationsController(IDecorationsService decorationsService)
        {
            _decorationsService = decorationsService;
        }

        /// <summary>
        /// This method handles requests and get all decorations from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<DecorationsDTO>> GetAll()
        {
            var model = _decorationsService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get decorations from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid decorations entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<DecorationsDTO>> GetById(int id)
        {
            var model = await _decorationsService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(DecorationsDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _decorationsService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(DecorationsDTO entity)
        {
            if (entity != null)
            {
                await _decorationsService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(DecorationsDTO entity)
        {   
            if (entity != null)
            {
                await _decorationsService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
