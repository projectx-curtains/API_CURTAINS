using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IColorRepository
    {
        IEnumerable<ColorModel> GetAll();
        Task<ColorModel> GetByIdAsync(int Id);
        Task<EntityEntry<ColorModel>> InsertAsync(ColorModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(ColorModel entity);
        Task RemoveAsync(ColorModel entity);
        void SaveChangesAsync();
    }
}
