using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Shared.Exceptions;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> MarketingInfoRepository</c> describes entity interaction model for database
    /// </summary>
    public class MarketingInfoRepository : IMarketingInfoRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<MarketingInfoModel> Query => _curtainsContext.MarketingInfos;
        #endregion

        public MarketingInfoRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> MarketingInfoModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of MarketingInfoModel entities in List MarketingInfo</return>
        public IEnumerable<MarketingInfoModel> GetAll()
        {
            if (!_curtainsContext.MarketingInfos.Any())
            {
                _logger.LogError("Marketing infos table is empty");
                throw new ResourceNotFoundException();
            }

            return _curtainsContext.MarketingInfos.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> MarketingInfoModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid MarketingInfos entity idetifier</param>
        /// <returns>MarketingInfo model</return>
        public async Task<MarketingInfoModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("MarketingInfo model is null");
                throw new ArgumentNullException("MarketingInfo model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> MarketingInfoModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > MarketingInfoModel MarketingInfo</param>
        /// <returns>EntityEntry<MarketingInfoModel></return>
        public async Task<EntityEntry<MarketingInfoModel>> InsertAsync(MarketingInfoModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("MarketingInfo model is null");
                throw new ArgumentNullException("MarketingInfo model is null");
            }

            var result = await _curtainsContext.MarketingInfos.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> MarketingInfoModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > MarketingInfoModel MarketingInfo</param>
        public async Task UpdateAsync(MarketingInfoModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.MarketingInfos.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> MarketingInfoModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > MarketingInfoModel MarketingInfo</param>
        public async Task RemoveAsync(MarketingInfoModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("MarketingInfo model is null");
                throw new ArgumentNullException("MarketingInfo model is null");
            }

            _curtainsContext.MarketingInfos.Remove(entity);
            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method save changes in database
        /// </summary>
        public async void SaveChangesAsync()
        {
            await _curtainsContext.SaveChangesAsync();
        }
        #endregion
    }

}
