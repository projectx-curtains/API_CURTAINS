using Microsoft.AspNetCore.Mvc;
using Curtains.Application.DTO;
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

        [HttpPost]
        public async Task<ActionResult> Notify(ConstructorDTO entity)
        {
            await _notifyService.NotifyAsync(entity);
            return Ok();
        }
    }
}
