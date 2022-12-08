using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IMarketingInfoRepository
    {
        IEnumerable<MarketingInfoModel> GetAll();
        Task<MarketingInfoModel> GetByIdAsync(int Id);
        Task<EntityEntry<MarketingInfoModel>> InsertAsync(MarketingInfoModel entity, CancellationToken cancellationToken);
        Task UpdateAsync(MarketingInfoModel entity);
        Task RemoveAsync(MarketingInfoModel entity);
        void SaveChangesAsync();
    }
}
