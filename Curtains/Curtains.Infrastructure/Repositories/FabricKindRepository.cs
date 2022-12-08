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
    /// Class<c> FabricKindRepository</c> describes entity interaction model for database
    /// </summary>
    public class FabricKindRepository : IFabricKindRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<FabricKindModel> Query => _curtainsContext.FabricKinds;
        #endregion

        public FabricKindRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> FabricKindModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of FabricKindModel entities in List type</return>
        public IEnumerable<FabricKindModel> GetAll()
        {
            if (!_curtainsContext.FabricKinds.Any())
            {
                _logger.LogError("Fabric kinds table is empty");
                throw new ResourceNotFoundException();
            }

            return _curtainsContext.FabricKinds.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> FabricKindModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>FabricKind model</return>
        public async Task<FabricKindModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("FabricKind model is null");
                throw new ArgumentNullException("FabricKind model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> FabricKindModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > FabricKindModel type</param>
        /// <returns>EntityEntry<FabricKindModel></return>
        public async Task<EntityEntry<FabricKindModel>> InsertAsync(FabricKindModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("FabricKind model is null");
                throw new ArgumentNullException("FabricKind model is null");
            }

            var result = await _curtainsContext.FabricKinds.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> FabricKindModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > FabricKindModel</param>
        public async Task UpdateAsync(FabricKindModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.FabricKinds.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> FabricKindModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > FabricKindModel</param>
        public async Task RemoveAsync(FabricKindModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("FabricKind model is null");
                throw new ArgumentNullException("FabricKind model is null");
            }

            _curtainsContext.FabricKinds.Remove(entity);
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
