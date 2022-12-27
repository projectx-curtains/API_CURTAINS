using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IProductImageRepository
    {
        IEnumerable<ProductImageModel> GetAll();
        Task<ProductImageModel> GetByIdAsync(int Id);
        Task<EntityEntry<ProductImageModel>> InsertAsync(ProductImageModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(ProductImageModel entity);
        Task RemoveAsync(ProductImageModel entity);
        void SaveChangesAsync();
    }
}
