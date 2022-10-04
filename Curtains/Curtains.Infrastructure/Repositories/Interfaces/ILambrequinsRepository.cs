using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ILambrequinsRepository
    {
        IEnumerable<LambrequinsModel> GetAll();
        Task<LambrequinsModel> GetByIdAsync(int Id);
        Task<EntityEntry<LambrequinsModel>> InsertAsync(LambrequinsModel entity, CancellationToken cancellationToken);
        void UpdateAsync(LambrequinsModel entity);
        void RemoveAsync(LambrequinsModel entity);
        void SaveChangesAsync();
    }
}
