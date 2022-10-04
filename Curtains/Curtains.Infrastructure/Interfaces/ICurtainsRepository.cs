using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsRepository
    {
        IEnumerable<CurtainsModel> GetAll();
        Task<CurtainsModel> GetByIdAsync(int Id);
        Task<EntityEntry<CurtainsModel>> InsertAsync(CurtainsModel entity, CancellationToken cancellationToken);
        void UpdateAsync(CurtainsModel entity);
        void RemoveAsync(CurtainsModel entity);
        void SaveChangesAsync();
    }
}
