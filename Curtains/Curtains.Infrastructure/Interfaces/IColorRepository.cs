using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IColorRepository
    {
        IEnumerable<ColorModel> GetAll();
        Task<ColorModel> GetByIdAsync(int Id);
        Task<EntityEntry<ColorModel>> InsertAsync(ColorModel entity, CancellationToken cancellationToken);
        void UpdateAsync(ColorModel entity);
        void RemoveAsync(ColorModel entity);
        void SaveChangesAsync();
    }
}
