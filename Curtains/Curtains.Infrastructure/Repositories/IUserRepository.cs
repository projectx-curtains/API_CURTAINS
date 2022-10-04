using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        Task<UserModel> GetByIdAsync(int Id);
        Task<EntityEntry<UserModel>> InsertAsync(UserModel entity, CancellationToken cancellationToken);
        void UpdateAsync(UserModel entity);
        void RemoveAsync(UserModel entity);
        void SaveChangesAsync();
    }
}
