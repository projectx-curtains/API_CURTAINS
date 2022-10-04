using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IConsistencyRepository
    {
        IEnumerable<ConsistencyModel> GetAll();
        Task<ConsistencyModel> GetByIdAsync(int Id);
        Task<EntityEntry<ConsistencyModel>> InsertAsync(ConsistencyModel entity, CancellationToken cancellationToken);
        void UpdateAsync(ConsistencyModel entity);
        void RemoveAsync(ConsistencyModel entity);
        void SaveChangesAsync();
    }
}
