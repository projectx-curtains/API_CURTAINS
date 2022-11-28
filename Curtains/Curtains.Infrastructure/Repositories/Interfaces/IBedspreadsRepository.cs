using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IBedspreadsRepository
    {
        IEnumerable<BedspreadsModel> GetAll();
        Task<BedspreadsModel> GetByIdAsync(int Id);
        Task<EntityEntry<BedspreadsModel>> InsertAsync(BedspreadsModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(BedspreadsModel entity);
        Task RemoveAsync(BedspreadsModel entity);
        void SaveChangesAsync();
    }
}
