using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IProductSetRepository
    {
        IEnumerable<ProductSetModel> GetAll();
        Task<ProductSetModel> GetByIdAsync(int Id);
        Task<EntityEntry<ProductSetModel>> InsertAsync(ProductSetModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(ProductSetModel entity);
        Task RemoveAsync(ProductSetModel entity);
        void SaveChangesAsync();
    }
}
