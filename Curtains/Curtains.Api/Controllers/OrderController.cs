using Microsoft.AspNetCore.Mvc;
using Curtains.Application.CurtainsService.Interfaces;

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

        /// <summary>
        /// Notifies the customer of a new order.
        /// </summary>
        /// <param name="entity">Order about which we must notify customer.</param>
        /// <returns>Http code 200.</returns>
        [HttpPost]
        public async Task<ActionResult> Notify(object entity)
        {
            await _notifyService.NotifyAsync(entity);
            return Ok();
        }
    }
}
