using Microsoft.AspNetCore.Mvc;
using Curtains.Application.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// This controller <c> ReviewController </c> for CRUID operations in database
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

        /// <summary>
        /// This method handles requests and get all Reviews from database.
        /// </summary>
        /// <returns> Http status code </returns>
        [HttpGet]
        public ActionResult<IEnumerable<ReviewDTO>> GetAll()
        {
            var model = _service.GetAll();

            if (model != null)
            {
                return Ok(model);
            }
            return BadRequest(nameof(GetAll));
        }

        /// <summary>
        /// This method handles requests and get Review from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid Reviews entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewDTO>> GetById(int id)
        {
            var model = await _service.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds Review to database.
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(ReviewDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _service.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        /// <summary>
        /// This method handles requests and updates the Review in the database.
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> Http status code </returns>
        [HttpPut]
        public async Task<ActionResult> Update(ReviewDTO entity)
        {
            if (entity != null)
            {
                await _service.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        /// <summary>
        /// This method handles requests and remove the Review in the database.
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> Http status code </returns>
        [HttpDelete]
        public async Task<ActionResult> Remove(ReviewDTO entity)
        {
            if (entity != null)
            {
                await _service.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
