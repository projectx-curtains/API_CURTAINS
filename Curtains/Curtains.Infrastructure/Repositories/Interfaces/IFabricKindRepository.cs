using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IFabricKindRepository
    {
        IEnumerable<FabricKindModel> GetAll();
        Task<FabricKindModel> GetByIdAsync(int Id);
        Task<EntityEntry<FabricKindModel>> InsertAsync(FabricKindModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(FabricKindModel entity);
        Task RemoveAsync(FabricKindModel entity);
        void SaveChangesAsync();
    }
}
