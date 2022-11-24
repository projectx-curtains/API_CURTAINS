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

        /// This method handles requests and get filters for curtains.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetCurtainsFilters))]
        public ActionResult<CurtainsFilter> GetCurtainsFilters()
        {
            var model = _service.GetCurtainsFilters();
            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetCurtainsFilters));
        }

        /// This method handles requests and get filters for fabric.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetFabricFilters))]
        public ActionResult<FabricFilter> GetFabricFilters()
        {
            var model = _service.GetFabricFilters();
            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetFabricFilters));
        }

        /// This method handles requests and get filters for pillows.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetPillowsFilters))]
        public ActionResult<PillowsFilter> GetPillowsFilters()
        {
            var model = _service.GetPillowsFilters();
            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetPillowsFilters));
        }

        /// This method handles requests and get filters for bedspreads.        
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet(nameof(GetBedspreadsFilters))]
        public ActionResult<BedspreadsFilter> GetBedspreadsFilters()
        {
            var model = _service.GetBedspreadsFilters();
            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetBedspreadsFilters));
        }
        #endregion
    }
}
