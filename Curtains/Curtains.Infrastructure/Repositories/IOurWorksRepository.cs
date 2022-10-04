using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IOurWorksRepository
    {
        IEnumerable<OurWorksModel> GetAll();
        Task<OurWorksModel> GetByIdAsync(int Id);
        Task<EntityEntry<OurWorksModel>> InsertAsync(OurWorksModel entity, CancellationToken cancellationToken);
        void UpdateAsync(OurWorksModel entity);
        void RemoveAsync(OurWorksModel entity);
        void SaveChangesAsync();
    }
}
