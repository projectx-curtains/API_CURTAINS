using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// This controller <c> PillowsController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PillowsController : ControllerBase
    {
        private readonly IPillowsService _pillowsService;

        public PillowsController(IPillowsService pillowsService)
        {
            _pillowsService = pillowsService;
        }

        /// <summary>
        /// This method handles requests and get all pillows from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<PillowsDTO>> GetAll()
        {
            var model = _pillowsService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get pillows from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid pillows entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<PillowsDTO>> GetById(int id)
        {
            var model = await _pillowsService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds Pillow to database.
        /// </summary>
        /// <param name="entity"> PillowsDTO Pillow </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(PillowsDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _pillowsService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(PillowsDTO entity)
        {
            if (entity != null)
            {
                await _pillowsService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(PillowsDTO entity)
        {
            if (entity != null)
            {
                await _pillowsService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
