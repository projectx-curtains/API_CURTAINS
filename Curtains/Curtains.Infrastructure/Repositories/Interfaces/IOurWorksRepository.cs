using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IOurWorksRepository
    {
        IEnumerable<OurWorksModel> GetAll();
        Task<OurWorksModel> GetByIdAsync(int Id);
        Task<EntityEntry<OurWorksModel>> InsertAsync(OurWorksModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(OurWorksModel entity);
        Task RemoveAsync(OurWorksModel entity);
        void SaveChangesAsync();
    }
}
