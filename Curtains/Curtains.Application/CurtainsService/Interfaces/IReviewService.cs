using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.Interfaces
{
    /// <summary>
    /// This interface describes the interaction model of the data transfer object to the database.
    /// </summary>
    public interface IReviewService
    {
        /// <summary>
        /// This method get all reviews.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ReviewDTO> GetAll();

        /// <summary>
        /// This method get review by id.
        /// </summary>
        /// <param name="Id"> Guid Reviews entity idetifier </param>
        /// <returns> ReviewDTO </returns>
        public Task<ReviewDTO> GetByIdAsync(int Id);

        /// <summary>
        /// This method adds the review to the database.
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> A task that represents the asynchronous execute operation. </returns>
        public Task InsertAsync(ReviewDTO entity, CancellationToken cancelationToken);

        /// <summary>
        /// This method updates the review in the database.
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> A task that represents the asynchronous execute operation. </returns>
        public Task UpdateAsync(ReviewDTO entity);

        /// <summary>
        /// This method removes the review from the database.
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> A task that represents the asynchronous execute operation. </returns>
        public Task RemoveAsync(ReviewDTO entity);
    }
}
