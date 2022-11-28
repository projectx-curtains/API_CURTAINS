using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IManufacturerRepository
    {
        IEnumerable<ManufacturerModel> GetAll();
        Task<ManufacturerModel> GetByIdAsync(int Id);
        Task<EntityEntry<ManufacturerModel>> InsertAsync(ManufacturerModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(ManufacturerModel entity);
        Task RemoveAsync(ManufacturerModel entity);
        void SaveChangesAsync();
    }
}
