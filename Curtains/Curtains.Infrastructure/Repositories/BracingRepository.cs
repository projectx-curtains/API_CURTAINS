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
    /// Class<c> BracingRepository</c> describes entity interaction model for database
    /// </summary>
    public class BracingRepository : IBracingRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<BracingModel> Query => _curtainsContext.Bracings;
        #endregion

        public BracingRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> BracingModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of BracingModel entities in List type</return>
        public IEnumerable<BracingModel> GetAll()
        {
            if (!_curtainsContext.Bracings.Any())
            {
                _logger.LogError("Bracings table is empty");
                throw new ResourceNotFoundException();
            }

            return _curtainsContext.Bracings.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> BracingModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>BracingModel model</return>
        public async Task<BracingModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Bracing model is null");
                throw new ArgumentNullException("Bracing model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> BracingModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > BracingModel type</param>
        /// <returns>EntityEntry<BracingModel></return>
        public async Task<EntityEntry<BracingModel>> InsertAsync(BracingModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Bracing model is null");
                throw new ArgumentNullException("Bracing model is null");
            }

            var result = await _curtainsContext.Bracings.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> BracingModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > BracingModel type</param>
        public async Task UpdateAsync(BracingModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Bracings.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> BracingModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > BracingModel type</param>
        public async Task RemoveAsync(BracingModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Bracing model is null");
                throw new ArgumentNullException("Bracing model is null");
            }

            _curtainsContext.Bracings.Remove(entity);
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
