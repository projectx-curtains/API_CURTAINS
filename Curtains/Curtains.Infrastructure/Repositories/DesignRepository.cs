using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Curtains.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> DesignRepository</c> describes entity interaction model for database
    /// </summary>
    public class DesignRepository : IDesignRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<DesignModel> Query => _curtainsContext.Designs;
        #endregion

        public DesignRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> DesignModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of DesignModel entities in List designs</return>
        public IEnumerable<DesignModel> GetAll()
        {
            return _curtainsContext.Designs.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> DesignModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Design entity idetifier</param>
        /// <returns>Design model</return>
        public async Task<DesignModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Design model is null");
                throw new ArgumentNullException("Design model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> DesignModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > DesignModel</param>
        /// <returns>EntityEntry<DesignModel></return>
        public async Task<EntityEntry<DesignModel>> InsertAsync(DesignModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Design model is null");
                throw new ArgumentNullException("Design model is null");
            }

            var result = await _curtainsContext.Designs.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> DesignModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > DesignModel</param>
        public async Task UpdateAsync(DesignModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Designs.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> DesignModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > DesignModel</param>
        public async Task RemoveAsync(DesignModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Design model is null");
                throw new ArgumentNullException("Design model is null");
            }

            _curtainsContext.Designs.Remove(entity);
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
