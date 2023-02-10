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
    /// This controller <c> MetaDataController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MetaDataController : ControllerBase
    {
        private readonly IMetaDataService _metaDataService;

        public MetaDataController(IMetaDataService metaDataService)
        {
            _metaDataService = metaDataService;
        }

        /// <summary>
        /// This method handles requests and get all meta data from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<MetaDataDTO>> GetAll()
        {
            var model = _metaDataService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get meta data from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid meta data entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MetaDataDTO>> GetById(int id)
        {
            var model = await _metaDataService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds meta data to database.
        /// </summary>
        /// <param name="entity"> MetaDataDTO meta data </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(MetaDataDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _metaDataService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(MetaDataDTO entity)
        {
            if (entity != null)
            {
                await _metaDataService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(MetaDataDTO entity)
        {
            if (entity != null)
            {
                await _metaDataService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
