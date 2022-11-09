using Microsoft.AspNetCore.Mvc;
using Curtains.Application.Interfaces;
using Curtains.Application.DTO;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.CurtainsService;

namespace Curtains.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly INotifyService _notifyService;
        private readonly IOrderService _orderService;

        public OrderController(INotifyService notifyService, IOrderService orderService)
        {
            _notifyService = notifyService;
            _orderService = orderService;
        }

        /// <summary>
        /// This method handles requests and get all our works from database.
        /// </summary>
        /// <returns> Http status code 200 </returns>
        [HttpGet]
        public ActionResult<IEnumerable<OrderDTO>> GetAll()
        {
            var orders = _orderService.GetAll();
            return Ok("Chekay pochty");
        }

        [HttpPost]
        public async Task<ActionResult> Insert(OrderDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _orderService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }
    }
}
