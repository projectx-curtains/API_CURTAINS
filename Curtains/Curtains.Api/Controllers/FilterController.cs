using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Application.DTO.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// This controller <c> FilterController </c> for getting all filters using http requests
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        #region FieldsRegion
        private readonly IFilterService _service;
        #endregion

        public FilterController(IFilterService service)
        {
            _service = service;
        }

        #region MethodsRegion
        /// This method handles requests and get filters for all categories.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetAllCategoriesFilters))]
        public ActionResult<BaseFilter> GetAllCategoriesFilters()
        {
            var model = _service.GetAllCategoriesFilters();
            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAllCategoriesFilters));
        }
        #endregion
    }
}
