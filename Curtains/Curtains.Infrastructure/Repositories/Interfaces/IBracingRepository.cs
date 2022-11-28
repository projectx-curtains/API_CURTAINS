using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IBracingRepository
    {
        IEnumerable<BracingModel> GetAll();
        Task<BracingModel> GetByIdAsync(int Id);
        Task<EntityEntry<BracingModel>> InsertAsync(BracingModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(BracingModel entity);
        Task RemoveAsync(BracingModel entity);
        void SaveChangesAsync();
    }
}
