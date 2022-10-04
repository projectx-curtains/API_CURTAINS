using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsKindRepository
    {
        IEnumerable<CurtainsKindModel> GetAll();
        Task<CurtainsKindModel> GetByIdAsync(int Id);
        Task<EntityEntry<CurtainsKindModel>> InsertAsync(CurtainsKindModel entity, CancellationToken cancellationToken);
        void UpdateAsync(CurtainsKindModel entity);
        void RemoveAsync(CurtainsKindModel entity);
        void SaveChangesAsync();
    }
}
