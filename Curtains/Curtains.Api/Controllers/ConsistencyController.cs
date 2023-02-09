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
    /// This controller <c> ConsistencyController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ConsistencyController : ControllerBase
    {
        private readonly IConsistencyService _consistencyService;

        public ConsistencyController(IConsistencyService consistencyService)
        {
            _consistencyService = consistencyService;
        }

        /// <summary>
        /// This method handles requests and get all consistency from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<ConsistencyDTO>> GetAll()
        {
            var model = _consistencyService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get consistency from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid consistency entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsistencyDTO>> GetById(int id)
        {
            var model = await _consistencyService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(ConsistencyDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _consistencyService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(ConsistencyDTO entity)
        {
            if (entity != null)
            {
                await _consistencyService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(ConsistencyDTO entity)
        {
            if (entity != null)
            {
                await _consistencyService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
