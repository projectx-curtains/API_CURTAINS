using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace Curtains.Infrastructure.Interfaces
{
    public interface IMetaDataRepository
    {
        IEnumerable<MetaDataModel> GetAll();
        Task<MetaDataModel> GetByIdAsync(int Id);
        Task<EntityEntry<MetaDataModel>> InsertAsync(MetaDataModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(MetaDataModel entity);
        Task RemoveAsync(MetaDataModel entity);
        void SaveChangesAsync();
    }
}
