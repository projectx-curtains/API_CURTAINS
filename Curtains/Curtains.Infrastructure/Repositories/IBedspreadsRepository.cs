using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IBedspreadsRepository
    {
        IEnumerable<BedspreadsModel> GetAll();
        Task<BedspreadsModel> GetByIdAsync(int Id);
        Task<EntityEntry<BedspreadsModel>> InsertAsync(BedspreadsModel entity, CancellationToken cancellationToken);
        void UpdateAsync(BedspreadsModel entity);
        void RemoveAsync(BedspreadsModel entity);
        void SaveChangesAsync();
    }
}
