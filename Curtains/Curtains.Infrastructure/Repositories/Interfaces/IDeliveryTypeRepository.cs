using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IDeliveryTypeRepository
    {
        IEnumerable<DeliveryTypeModel> GetAll();
        Task<DeliveryTypeModel> GetByIdAsync(int Id);
        Task<EntityEntry<DeliveryTypeModel>> InsertAsync(DeliveryTypeModel entity, CancellationToken cancellationToken);
        void UpdateAsync(DeliveryTypeModel entity);
        void RemoveAsync(DeliveryTypeModel entity);
        void SaveChangesAsync();
    }
}
