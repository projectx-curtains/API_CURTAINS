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

        [HttpPost("catalog")]
        public async Task<ActionResult> Notify(OrderDTO entity)
        {
            await _notifyService.NotifyAsync(entity);
            return Ok();
        }

        [HttpPost("order")]
        public async Task<ActionResult> Notify(ConstructorDTO entity)
        {
            await _notifyService.NotifyAsync(entity);
            return Ok();
        }
    }
}
