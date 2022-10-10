using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.Interfaces
{
    public interface IReviewService
    {
        public IEnumerable<ReviewDTO> GetAll();

        public Task<ReviewDTO> GetByIdAsync(int Id);

        public Task InsertAsync(ReviewDTO entity, CancellationToken cancelationToken);

        public Task UpdateAsync(ReviewDTO entity);

        public Task RemoveAsync(ReviewDTO entity);
    }
}
