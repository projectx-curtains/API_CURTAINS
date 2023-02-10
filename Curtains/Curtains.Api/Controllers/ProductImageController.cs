using Curtains.Application.CurtainsService;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// This controller <c> ProductImageController </c> handles requests and
    /// changes, deletes, sends, gets feedback data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService service)
        {
            _productImageService = service;
        }

        /// <summary>
        /// This method handles requests and get all new ProductImages from database.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetNewItems))]
        public ActionResult<IEnumerable<ProductImageDTO>> GetNewItems()
        {
            var model = _productImageService.GetNewItems();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetNewItems));
        }

        /// <summary>
        /// This method handles requests and get all popular ProductImages from database.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetPopularItems))]
        public ActionResult<IEnumerable<ProductImageDTO>> GetPopularItems()
        {
            var model = _productImageService.GetPopularItems();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetPopularItems));
        }

        /// <summary>
        /// This method handles requests and get all product images from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<ProductImageDTO>> GetAll()
        {
            var model = _productImageService.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get product image from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid product image entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductImageDTO>> GetById(int id)
        {
            var model = await _productImageService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds Product image to database.
        /// </summary>
        /// <param name="entity"> ProductImageDTO Product image </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(ProductImageDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _productImageService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(ProductImageDTO entity)
        {
            if (entity != null)
            {
                await _productImageService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(ProductImageDTO entity)
        {
            if (entity != null)
            {
                await _productImageService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}