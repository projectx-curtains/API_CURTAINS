using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<OrderModel> GetAll();
        Task<OrderModel> GetByIdAsync(int Id);
        Task<EntityEntry<OrderModel>> InsertAsync(OrderModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(OrderModel entity);
        Task RemoveAsync(OrderModel entity);
        void SaveChangesAsync();
    }
}
