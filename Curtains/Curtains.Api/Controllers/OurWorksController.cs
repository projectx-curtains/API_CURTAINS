using Microsoft.AspNetCore.Mvc;
using Curtains.Application.DTO;
using Curtains.Application.CurtainsService.Interfaces;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// This controller <c> OurWorksController </c> for getting all our works using http requests
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OurWorksController : ControllerBase
    {
        private readonly IOurWorksService _ourWorksService;

        public OurWorksController(IOurWorksService ourWorksService)
        {
            _ourWorksService = ourWorksService;
        }

        /// <summary>
        /// This method handles requests and get all our works from database.
        /// </summary>
        /// <returns> Http status code 200 </returns>
        [HttpGet]
        public ActionResult<IEnumerable<OurWorksDTO>> GetAll()
        {
            var model = _ourWorksService.GetAll();
            return Ok(model);
        }
    }
}
