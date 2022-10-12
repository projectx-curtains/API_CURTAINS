using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IFabricRepository
    {
        IEnumerable<FabricModel> GetAll();
        Task<FabricModel> GetByIdAsync(int Id);
        Task<EntityEntry<FabricModel>> InsertAsync(FabricModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(FabricModel entity);
        Task RemoveAsync(FabricModel entity);
        void SaveChangesAsync();
    }
}
