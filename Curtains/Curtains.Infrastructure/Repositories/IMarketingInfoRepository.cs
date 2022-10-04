using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IMarketingInfoRepository
    {
        IEnumerable<MarketingInfoModel> GetAll();
        Task<MarketingInfoModel> GetByIdAsync(int Id);
        Task<EntityEntry<MarketingInfoModel>> InsertAsync(MarketingInfoModel entity, CancellationToken cancellationToken);
        void UpdateAsync(MarketingInfoModel entity);
        void RemoveAsync(MarketingInfoModel entity);
        void SaveChangesAsync();
    }
}
