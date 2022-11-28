using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> MetaDataRepository</c> describes entity interaction model for database
    /// </summary>
    public class MetaDataRepository : IMetaDataRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<MetaDataModel> Query => _curtainsContext.MetaDatas;
        #endregion

        public MetaDataRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> MetadataModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of MetadataModel entities in List type</return>
        public IEnumerable<MetaDataModel> GetAll()
        {
            return _curtainsContext.MetaDatas.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> MetadataModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>MetadataModel</return>
        public async Task<MetaDataModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("MetaData model is null");
                throw new ArgumentNullException("Metadata model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> MetadataModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > MetadataModel type</param>
        /// <returns>EntityEntry<MetadataModel></return>
        public async Task<EntityEntry<MetaDataModel>> InsertAsync(MetaDataModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Metadata model is null");
                throw new ArgumentNullException("Metadata model is null");
            }

            var result = await _curtainsContext.MetaDatas.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> MetadataModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > MetadataModel type</param>
        public async Task UpdateAsync(MetaDataModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.MetaDatas.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> MetadataModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > MetadataModel type</param>
        public async Task RemoveAsync(MetaDataModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Metadata model is null");
                throw new ArgumentNullException("Metadata model is null");
            }

            _curtainsContext.MetaDatas.Remove(entity);
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
