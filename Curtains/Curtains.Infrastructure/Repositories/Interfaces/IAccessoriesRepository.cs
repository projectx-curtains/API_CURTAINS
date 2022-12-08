using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IAccessoriesRepository
    {
        IEnumerable<AccessoriesModel> GetAll();
        Task<AccessoriesModel> GetByIdAsync(int Id);
        Task<EntityEntry<AccessoriesModel>> InsertAsync(AccessoriesModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(AccessoriesModel entity);
        Task RemoveAsync(AccessoriesModel entity);
        void SaveChangesAsync();
    }
}
