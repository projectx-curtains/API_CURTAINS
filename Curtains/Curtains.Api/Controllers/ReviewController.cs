using Microsoft.AspNetCore.Mvc;
using Curtains.Application.Interfaces;
using Curtains.Application.DTO;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReviewDTO>> GetAll()
        {
            
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<ReviewDTO>> GetById(int id)
        {
            
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<EntityEntry<ReviewDTO>>> Insert(ReviewDTO entity, CancellationToken token)
        {
            
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(ReviewDTO entity)
        {
        
            return Ok();
        }

        [HttpDelete]
        public ActionResult Remove(ReviewDTO entity)
        {

            return Ok();
        }
    }
}
