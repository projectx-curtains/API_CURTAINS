using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IPillowsRepository
    {
        IEnumerable<PillowsModel> GetAll();
        Task<PillowsModel> GetByIdAsync(int Id);
        Task<EntityEntry<PillowsModel>> InsertAsync(PillowsModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(PillowsModel entity);
        Task RemoveAsync(PillowsModel entity);
        void SaveChangesAsync();
    }
}
