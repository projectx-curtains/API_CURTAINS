using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsRepository
    {
        IEnumerable<CurtainsModel> GetAll();
        Task<CurtainsModel> GetByIdAsync(int Id);
        Task<EntityEntry<CurtainsModel>> InsertAsync(CurtainsModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(CurtainsModel entity);
        Task RemoveAsync(CurtainsModel entity);
        void SaveChangesAsync();
    }
}
