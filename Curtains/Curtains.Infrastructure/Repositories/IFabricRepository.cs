using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IFabricRepository
    {
        IEnumerable<FabricModel> GetAll();
        Task<FabricModel> GetByIdAsync(int Id);
        Task<EntityEntry<FabricModel>> InsertAsync(FabricModel entity, CancellationToken cancellationToken);
        void UpdateAsync(FabricModel entity);
        void RemoveAsync(FabricModel entity);
        void SaveChangesAsync();
    }
}
