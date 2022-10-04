using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IAccessoriesRepository
    {
        IEnumerable<AccessoriesModel> GetAll();
        Task<AccessoriesModel> GetByIdAsync(int Id);
        Task<EntityEntry<AccessoriesModel>> InsertAsync(AccessoriesModel entity, CancellationToken cancellationToken);
        void UpdateAsync(AccessoriesModel entity);
        void RemoveAsync(AccessoriesModel entity);
        void SaveChangesAsync();
    }
}
