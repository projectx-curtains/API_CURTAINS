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
    /// Class<c> CurtainsRepository</c> describes entity interaction model for database
    /// </summary>
    public class CurtainsRepository : ICurtainsRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<CurtainsModel> Query => _curtainsContext.Curtains
            .Include(x => x.Fabric)
            .Include(x => x.CurtainsKind)
            .Include(x => x.CurtainsType)
            .Include(x => x.Fabric.Color)
            .Include(x => x.Material);
        #endregion

        public CurtainsRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> CurtainsModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of CurtainsModel entities in List type</return>
        public IEnumerable<CurtainsModel> GetAll()
        {
            return Query.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> CurtainsModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>Curtains model</return>
        public async Task<CurtainsModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Curtains model is null");
                throw new ArgumentNullException("Curtains model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> CurtainsModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > CurtainsModel type</param>
        /// <returns>EntityEntry<CurtainsModel></return>
        public async Task<EntityEntry<CurtainsModel>> InsertAsync(CurtainsModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Curtains model is null");
                throw new ArgumentNullException("Curtains model is null");
            }

            var result = await _curtainsContext.Curtains.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> CurtainsModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > CurtainsModel type</param>
        public async Task UpdateAsync(CurtainsModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Curtains.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> CurtainsModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > CurtainsModel type</param>
        public async Task RemoveAsync(CurtainsModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Curtains model is null");
                throw new ArgumentNullException("Curtains model is null");
            }

            _curtainsContext.Curtains.Remove(entity);
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
