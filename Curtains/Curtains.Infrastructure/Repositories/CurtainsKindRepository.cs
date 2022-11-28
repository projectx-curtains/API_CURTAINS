using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> CurtainsKindRepository</c> describes entity interaction model for database
    /// </summary>
    public class CurtainsKindRepository : ICurtainsKindRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<CurtainsKindModel> Query => _curtainsContext.CurtainsKinds.Include(x => x.Curtains);
        #endregion

        public CurtainsKindRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> CurtainsKindModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of CurtainsKindModel entities in List type</return>
        public IEnumerable<CurtainsKindModel> GetAll()
        {
            return _curtainsContext.CurtainsKinds.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> CurtainsKindModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>CurtainsKind model</return>
        public async Task<CurtainsKindModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("CurtainsKind model is null");
                throw new ArgumentNullException("CurtainsKind model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> CurtainsKindModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > CurtainsKindModel type</param>
        /// <returns>EntityEntry<CurtainsKindModel></return>
        public async Task<EntityEntry<CurtainsKindModel>> InsertAsync(CurtainsKindModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("CurtainsKind model is null");
                throw new ArgumentNullException("CurtainsKind model is null");
            }

            var result = await _curtainsContext.CurtainsKinds.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> CurtainsKindModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > CurtainsKindModel type</param>
        public async Task UpdateAsync(CurtainsKindModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.CurtainsKinds.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> CurtainsKindModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > CurtainsKindModel type</param>
        public async Task RemoveAsync(CurtainsKindModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("CurtainsKind model is null");
                throw new ArgumentNullException("CurtainsKind model is null");
            }

            _curtainsContext.CurtainsKinds.Remove(entity);
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
