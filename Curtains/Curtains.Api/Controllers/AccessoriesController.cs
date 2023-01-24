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
    /// This controller <c> AccessoriesController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AccessoriesController : ControllerBase
    {
        private readonly IAccessoriesService _accessoriesService;

        public AccessoriesController(IAccessoriesService accessoriesService)
        {
            _accessoriesService = accessoriesService;
        }

        /// <summary>
        /// This method handles requests and get all accessories from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<AccessoriesDTO>> GetAll()
        {
            var model = _accessoriesService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get accessories from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid accessories entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<AccessoriesDTO>> GetById(int id)
        {
            var model = await _accessoriesService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(AccessoriesDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _accessoriesService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(AccessoriesDTO entity)
        {
            if (entity != null)
            {
                await _accessoriesService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(AccessoriesDTO entity)
        {
            if (entity != null)
            {
                await _accessoriesService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
