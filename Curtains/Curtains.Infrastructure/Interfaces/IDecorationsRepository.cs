using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IDecorationsRepository
    {
        IEnumerable<DecorationsModel> GetAll();
        Task<DecorationsModel> GetByIdAsync(int Id);
        Task<EntityEntry<DecorationsModel>> InsertAsync(DecorationsModel entity, CancellationToken cancellationToken);
        void UpdateAsync(DecorationsModel entity);
        void RemoveAsync(DecorationsModel entity);
        void SaveChangesAsync();
    }
}
