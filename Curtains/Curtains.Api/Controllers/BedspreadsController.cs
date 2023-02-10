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
    /// This controller <c> BedspreadsController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BedspreadsController : ControllerBase
    {
        private readonly IBedspreadsService _bedspreadsService;

        public BedspreadsController(IBedspreadsService bedspreadsService)
        {
            _bedspreadsService = bedspreadsService;
        }

        /// <summary>
        /// This method handles requests and get all bedspreads from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<BedspreadsDTO>> GetAll()
        {
            var model = _bedspreadsService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get bedspreads from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid bedspreads entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<BedspreadsDTO>> GetById(int id)
        {
            var model = await _bedspreadsService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(BedspreadsDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _bedspreadsService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(BedspreadsDTO entity)
        {
            if (entity != null)
            {
                await _bedspreadsService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(BedspreadsDTO entity)
        {
            if (entity != null)
            {
                await _bedspreadsService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
