using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<ReviewModel> GetAll();
        Task<ReviewModel> GetByIdAsync(int Id);
        Task<EntityEntry<ReviewModel>> InsertAsync(ReviewModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(ReviewModel entity);
        Task RemoveAsync(ReviewModel entity);
        void SaveChangesAsync();
    }
}
