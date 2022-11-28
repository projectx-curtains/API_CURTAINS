using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> FabricTypeRepository</c> describes entity interaction model for database
    /// </summary>
    public class FabricTypeRepository : IFabricTypeRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<FabricTypeModel> Query => _curtainsContext.FabricTypes;
        #endregion

        public FabricTypeRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> FabricTypeModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of FabricTypeModel entities in List type</return>
        public IEnumerable<FabricTypeModel> GetAll()
        {
            return _curtainsContext.FabricTypes.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> FabricTypeModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>FabricTypeModel</return>
        public async Task<FabricTypeModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("FabricType Model is null");
                throw new ArgumentNullException("FabricType model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> FabricTypeModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > FabricTypeModel</param>
        /// <returns>EntityEntry<FabricTypeModel></return>
        public async Task<EntityEntry<FabricTypeModel>> InsertAsync(FabricTypeModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Fabric type model is null");
                throw new ArgumentNullException("Fabric type model is null");
            }

            var result = await _curtainsContext.FabricTypes.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> FabricTypeModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > FabricTypeModel type</param>
        public async Task UpdateAsync(FabricTypeModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.FabricTypes.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> FabricTypeModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > FabricTypeModel</param>
        public async Task RemoveAsync(FabricTypeModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Fabric type model is null");
                throw new ArgumentNullException("Fabric type model is null");
            }

            _curtainsContext.FabricTypes.Remove(entity);
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
