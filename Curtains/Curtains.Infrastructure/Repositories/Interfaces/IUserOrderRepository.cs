﻿using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IUserOrderRepository
    {
        IEnumerable<UserOrderModel> GetAll();
        Task<UserOrderModel> GetByIdAsync(int Id);
        Task<EntityEntry<UserOrderModel>> InsertAsync(UserOrderModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(UserOrderModel entity);
        Task RemoveAsync(UserOrderModel entity);
        void SaveChangesAsync();
    }
}