using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IFabricTypeRepository
    {
        IEnumerable<FabricTypeModel> GetAll();
        Task<FabricTypeModel> GetByIdAsync(int Id);
        Task<EntityEntry<FabricTypeModel>> InsertAsync(FabricTypeModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(FabricTypeModel entity);
        Task RemoveAsync(FabricTypeModel entity);
        void SaveChangesAsync();
    }
}
