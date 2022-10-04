using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IUserOrderRepository
    {
        IEnumerable<UserOrderModel> GetAll();
        Task<UserOrderModel> GetByIdAsync(int Id);
        Task<EntityEntry<UserOrderModel>> InsertAsync(UserOrderModel entity, CancellationToken cancellationToken);
        void UpdateAsync(UserOrderModel entity);
        void RemoveAsync(UserOrderModel entity);
        void SaveChangesAsync();
    }
}
