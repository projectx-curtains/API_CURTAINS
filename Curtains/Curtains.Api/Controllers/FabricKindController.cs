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
    /// This controller <c> FabricKindController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FabricKindController : ControllerBase
    {
        private readonly IFabricKindService _fabricKindService;

        public FabricKindController(IFabricKindService fabricKindService)
        {
            _fabricKindService = fabricKindService;
        }

        /// <summary>
        /// This method handles requests and get all fabric kind from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<FabricKindDTO>> GetAll()
        {
            var model = _fabricKindService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get favric kind from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid fabric kind entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<FabricKindDTO>> GetById(int id)
        {
            var model = await _fabricKindService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(FabricKindDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _fabricKindService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(FabricKindDTO entity)
        {
            if (entity != null)
            {
                await _fabricKindService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(FabricKindDTO entity)
        {   
            if (entity != null)
            {
                await _fabricKindService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
