using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IConsistencyRepository
    {
        IEnumerable<ConsistencyModel> GetAll();
        Task<ConsistencyModel> GetByIdAsync(int Id);
        Task<EntityEntry<ConsistencyModel>> InsertAsync(ConsistencyModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(ConsistencyModel entity);
        Task RemoveAsync(ConsistencyModel entity);
        void SaveChangesAsync();
    }
}
