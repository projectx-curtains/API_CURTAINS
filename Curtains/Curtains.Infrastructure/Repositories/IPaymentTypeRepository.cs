using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IPaymentTypeRepository
    {
        IEnumerable<PaymentTypeModel> GetAll();
        Task<PaymentTypeModel> GetByIdAsync(int Id);
        Task<EntityEntry<PaymentTypeModel>> InsertAsync(PaymentTypeModel entity, CancellationToken cancellationToken);
        void UpdateAsync(PaymentTypeModel entity);
        void RemoveAsync(PaymentTypeModel entity);
        void SaveChangesAsync();
    }
}
