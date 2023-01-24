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
    /// This controller <c> FabricTypeController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FabricTypeController : ControllerBase
    {
        private readonly IFabricTypeService _fabricTypeService;

        public FabricTypeController(IFabricTypeService fabricTypeService)
        {
            _fabricTypeService = fabricTypeService;
        }

        /// <summary>
        /// This method handles requests and get all fabric type from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<FabricTypeDTO>> GetAll()
        {
            var model = _fabricTypeService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get fabric type from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid fabric type entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<FabricTypeDTO>> GetById(int id)
        {
            var model = await _fabricTypeService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(FabricTypeDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _fabricTypeService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(FabricTypeDTO entity)
        {
            if (entity != null)
            {
                await _fabricTypeService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(FabricTypeDTO entity)
        {
            if (entity != null)
            {
                await _fabricTypeService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
