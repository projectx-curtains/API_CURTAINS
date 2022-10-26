using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        Task<UserModel> GetByIdAsync(int Id);
        Task<EntityEntry<UserModel>> InsertAsync(UserModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(UserModel entity);
        Task RemoveAsync(UserModel entity);
        void SaveChangesAsync();
    }
}
