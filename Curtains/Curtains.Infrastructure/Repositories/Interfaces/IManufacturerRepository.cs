using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IManufacturerRepository
    {
        IEnumerable<ManufacturerModel> GetAll();
        Task<ManufacturerModel> GetByIdAsync(int Id);
        Task<EntityEntry<ManufacturerModel>> InsertAsync(ManufacturerModel entity, CancellationToken cancellationToken);
        void UpdateAsync(ManufacturerModel entity);
        void RemoveAsync(ManufacturerModel entity);
        void SaveChangesAsync();
    }
}
