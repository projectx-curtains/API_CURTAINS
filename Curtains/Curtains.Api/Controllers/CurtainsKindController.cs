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
    /// This controller <c> CurtainsKindController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CurtainsKindController : ControllerBase
    {
        private readonly ICurtainsKindService _curtainsKindService;

        public CurtainsKindController(ICurtainsKindService curtainsKindService)
        {
            _curtainsKindService = curtainsKindService;
        }

        /// <summary>
        /// This method handles requests and get all curtains kind from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<CurtainsKindDTO>> GetAll()
        {
            var model = _curtainsKindService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get curtains kind from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid curtains kind entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CurtainsKindDTO>> GetById(int id)
        {
            var model = await _curtainsKindService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(CurtainsKindDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _curtainsKindService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(CurtainsKindDTO entity)
        {
            if (entity != null)
            {
                await _curtainsKindService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(CurtainsKindDTO entity)
        {
            if (entity != null)
            {
                await _curtainsKindService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
