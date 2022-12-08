using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsTypeRepository
    {
        IEnumerable<CurtainsTypeModel> GetAll();
        Task<CurtainsTypeModel> GetByIdAsync(int Id);
        Task<EntityEntry<CurtainsTypeModel>> InsertAsync(CurtainsTypeModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(CurtainsTypeModel entity);
        Task RemoveAsync(CurtainsTypeModel entity);
        void SaveChangesAsync();
    }
}
