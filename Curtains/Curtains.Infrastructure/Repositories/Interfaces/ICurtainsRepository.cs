using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsRepository
    {
        IEnumerable<CurtainModel> GetAll();
        Task<CurtainModel> GetByIdAsync(int Id);
        Task<EntityEntry<CurtainModel>> InsertAsync(CurtainModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(CurtainModel entity);
        Task RemoveAsync(CurtainModel entity);
        void SaveChangesAsync();
    }
}
