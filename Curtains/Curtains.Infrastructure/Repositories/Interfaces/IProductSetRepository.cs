using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
