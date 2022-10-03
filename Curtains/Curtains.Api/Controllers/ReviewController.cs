using Microsoft.AspNetCore.Mvc;
using Curtains.Infrastructure.Database;
using Curtains.Application.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewDTO>>> Get()
        {
            await _service.GetAllReview();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(ReviewDTO reviewDTO)
        {
            await _service.AddReview(reviewDTO);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveReview(int reviewId)
        {
            await _service.RemoveReview(reviewId);
            return Ok();
        }

    }
}
