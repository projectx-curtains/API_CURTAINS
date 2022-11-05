using Microsoft.AspNetCore.Mvc;
using Curtains.Application.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly INotifyService _notifyService;

        public OrderController(INotifyService notifyService)
        {
            _notifyService = notifyService;
        }

        /// <summary>
        /// This method handles requests and get all our works from database.
        /// </summary>
        /// <returns> Http status code 200 </returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OurWorksDTO>>> GetAllAsync()
        {
            await _notifyService.NotifyAsync();
            return Ok("Chekay pochty");
        }
    }
}
