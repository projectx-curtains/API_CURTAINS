using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IMaterialRepository
    {
        IEnumerable<MaterialModel> GetAll();
        Task<MaterialModel> GetByIdAsync(int Id);
        Task<EntityEntry<MaterialModel>> InsertAsync(MaterialModel entity, CancellationToken cancellationToken);
        void UpdateAsync(MaterialModel entity);
        void RemoveAsync(MaterialModel entity);
        void SaveChangesAsync();
    }
}
