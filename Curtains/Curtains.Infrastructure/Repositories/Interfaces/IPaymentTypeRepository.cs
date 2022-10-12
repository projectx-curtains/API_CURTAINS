using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IPaymentTypeRepository
    {
        IEnumerable<PaymentTypeModel> GetAll();
        Task<PaymentTypeModel> GetByIdAsync(int Id);
        Task<EntityEntry<PaymentTypeModel>> InsertAsync(PaymentTypeModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(PaymentTypeModel entity);
        Task RemoveAsync(PaymentTypeModel entity);
        void SaveChangesAsync();
    }
}
