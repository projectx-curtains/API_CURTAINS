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
    /// This controller <c> ProductSetController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSetController : ControllerBase
    {
        private readonly IProductSetService _productSetService;

        public ProductSetController(IProductSetService productSetService)
        {
            _productSetService = productSetService;
        }

        /// <summary>
        /// This method handles requests and get all product sets from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<ProductSetDTO>> GetAll()
        {
            var model = _productSetService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get product set from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid product set entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductSetDTO>> GetById(int id)
        {
            var model = await _productSetService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds product set to database.
        /// </summary>
        /// <param name="entity"> ProductSetDTO product set </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(ProductSetDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _productSetService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(ProductSetDTO entity)
        {
            if (entity != null)
            {
                await _productSetService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(ProductSetDTO entity)
        {
            if (entity != null)
            {
                await _productSetService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
