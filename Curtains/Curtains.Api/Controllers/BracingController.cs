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
    /// This controller <c> BracingController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BracingController : ControllerBase
    {
        private readonly IBracingService _bracingService;

        public BracingController(IBracingService bracingService)
        {
            _bracingService = bracingService;
        }

        /// <summary>
        /// This method handles requests and get all bracing from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<BracingDTO>> GetAll()
        {
            var model = _bracingService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get bracing from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid bracing entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<BracingDTO>> GetById(int id)
        {
            var model = await _bracingService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(BracingDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _bracingService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(BracingDTO entity)
        {
            if (entity != null)
            {
                await _bracingService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(BracingDTO entity)
        {
            if (entity != null)
            {
                await _bracingService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
