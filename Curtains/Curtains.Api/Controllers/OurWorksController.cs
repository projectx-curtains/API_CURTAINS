using Microsoft.AspNetCore.Mvc;
using Curtains.Application.DTO;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.CurtainsService;

namespace Curtains.Api.Controllers
{
    /// <summary>
    /// This controller <c> OurWorksController </c> for getting all our works using http requests
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OurWorksController : ControllerBase
    {
        private readonly IOurWorksService _ourWorksService;

        public OurWorksController(IOurWorksService ourWorksService)
        {
            _ourWorksService = ourWorksService;
        }

        /// <summary>
        /// This method handles requests and get all our works from database.
        /// </summary>
        /// <returns> Http status code 200 </returns>
        [HttpGet]
        public ActionResult<IEnumerable<OurWorksDTO>> GetAll()
        {
            var model = _ourWorksService.GetAll();
            return Ok(model);
        }

        /// <summary>
        /// This method handles requests and get our work from database by entity Id.
        /// </summary>
        /// <param name="id"> Guid our work entity idetifier </param>
        /// <returns> Http status code </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<OurWorksDTO>> GetById(int id)
        {
            var model = await _ourWorksService.GetByIdAsync(id);

            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(nameof(GetById));
        }

        /// <summary>
        /// This method handles requests and adds our works to database.
        /// </summary>
        /// <param name="entity"> OurWorksDTO our works </param>
        /// <returns> Http status code </returns>
        [HttpPost]
        public async Task<ActionResult> Insert(OurWorksDTO entity, CancellationToken token)
        {
            if (entity != null)
            {
                await _ourWorksService.InsertAsync(entity, token);
                return CreatedAtAction(nameof(Insert), entity);
            }

            return BadRequest(nameof(Insert));
        }

        [HttpPut]
        public async Task<ActionResult> Update(OurWorksDTO entity)
        {
            if (entity != null)
            {
                await _ourWorksService.UpdateAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Update));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(OurWorksDTO entity)
        {
            if (entity != null)
            {
                await _ourWorksService.RemoveAsync(entity);
                return NoContent();
            }

            return BadRequest(nameof(Remove));
        }
    }
}
