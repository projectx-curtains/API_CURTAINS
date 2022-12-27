using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IDesignRepository
    {
        IEnumerable<DesignModel> GetAll();
        Task<DesignModel> GetByIdAsync(int Id);
        Task<EntityEntry<DesignModel>> InsertAsync(DesignModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(DesignModel entity);
        Task RemoveAsync(DesignModel entity);
        void SaveChangesAsync();
    }
}
