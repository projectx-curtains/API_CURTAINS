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
        private readonly IProductImageService _service;

        public ProductImageController(IProductImageService service)
        {
            _service = service;
        }

        /// <summary>
        /// This method handles requests and get all new ProductImages from database.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetNewItems))]
        public ActionResult<IEnumerable<ProductImageDTO>> GetNewItems()
        {
            var model = _service.GetNewItems();

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
            var model = _service.GetPopularItems();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetPopularItems));
        }
    }
}