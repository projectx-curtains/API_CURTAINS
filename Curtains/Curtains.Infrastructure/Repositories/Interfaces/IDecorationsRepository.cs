using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IDecorationsRepository
    {
        IEnumerable<DecorationsModel> GetAll();
        Task<DecorationsModel> GetByIdAsync(int Id);
        Task<EntityEntry<DecorationsModel>> InsertAsync(DecorationsModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(DecorationsModel entity);
        Task RemoveAsync(DecorationsModel entity);
        void SaveChangesAsync();
    }
}
