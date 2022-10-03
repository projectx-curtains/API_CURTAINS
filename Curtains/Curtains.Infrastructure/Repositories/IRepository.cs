using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T> GetByIdAsync(int Id);
        Task<EntityEntry<T>> InsertAsync(T entity, CancellationToken cancellationToken);
        void UpdateAsync(T entity);
        void RemoveAsync(T entity);
        void SaveChangesAsync();
    }
}
