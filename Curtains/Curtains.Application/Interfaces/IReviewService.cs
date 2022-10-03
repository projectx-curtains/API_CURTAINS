using Curtains.Application.DTO;

namespace Curtains.Application.Interfaces
{
    public interface IReviewService
    {
        public Task<List<ReviewDTO>> GetAllReview();
        public Task AddReview(ReviewDTO reviewDTO);
        public Task RemoveReview(int reviewId);
    }
}
