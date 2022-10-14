using Curtains.Application.CurtainsServices.Interfaces;
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
    /// This controller <c> ProductImageController </c> for CRUID operations in database
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
        /// <returns> Http status code 200 </returns>
        [HttpGet]
        public ActionResult<IEnumerable<ProductImageDTO>> GetNewItems()
        {
            var model = _service.GetAll().Where(n => n.MarketingInfo.IsNew);
            return Ok(model);
        }


    }
}
