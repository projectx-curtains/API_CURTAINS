using Microsoft.AspNetCore.Mvc;
using Curtains.Application.CurtainsServices.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// Controller notifying the customer about the receipt of the order
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly INotifyService _notifyService;

        public OrderController(INotifyService notifyService)
        {
            _notifyService = notifyService;
        }

        [HttpPost]
        public async Task<ActionResult> Notify(OrderDTO entity)
        {
            await _notifyService.NotifyAsync(entity);
            return Ok();
        }
    }
}
