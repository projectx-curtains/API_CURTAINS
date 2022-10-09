using Microsoft.AspNetCore.Mvc;
using Curtains.Application.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
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
            var model = _service.GetAll();
            return Ok(model);
        }

        [HttpGet("~/Id")]
        public async Task<ActionResult<ReviewDTO>> GetById(int id)
        {
            var model = await _service.GetByIdAsync(id);
            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult> Insert(ReviewDTO entity, CancellationToken token)
        {
            await _service.InsertAsync(entity, token);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(ReviewDTO entity)
        {
            _service.UpdateAsync(entity);
            return Ok();
        }

        [HttpDelete]
        public ActionResult Remove(ReviewDTO entity)
        {
            _service.RemoveAsync(entity);
            return Ok();
        }
    }
}
