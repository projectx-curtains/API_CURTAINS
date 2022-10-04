using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IPillowsRepository
    {
        IEnumerable<PillowsModel> GetAll();
        Task<PillowsModel> GetByIdAsync(int Id);
        Task<EntityEntry<PillowsModel>> InsertAsync(PillowsModel entity, CancellationToken cancellationToken);
        void UpdateAsync(PillowsModel entity);
        void RemoveAsync(PillowsModel entity);
        void SaveChangesAsync();
    }
}
