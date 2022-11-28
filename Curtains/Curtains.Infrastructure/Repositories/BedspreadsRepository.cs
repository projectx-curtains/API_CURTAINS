using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> BedspreadsRepository</c> describes entity interaction model for database
    /// </summary>
    public class BedspreadsRepository : IBedspreadsRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<BedspreadsModel> Query => _curtainsContext.Bedspreads;
        #endregion

        public BedspreadsRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> BedspreadsModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of BedspreadsModel entities in List type</return>
        public IEnumerable<BedspreadsModel> GetAll()
        {
            return _curtainsContext.Bedspreads.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> BedspreadsModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>Bedspreads model</return>
        public async Task<BedspreadsModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Bedspreads model is null");
                throw new ArgumentNullException("Bedspreads model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> BedspreadsModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > BedspreadsModel type</param>
        /// <returns>EntityEntry<BedspreadsModel></return>
        public async Task<EntityEntry<BedspreadsModel>> InsertAsync(BedspreadsModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Bedspreads model is null");
                throw new ArgumentNullException("Bedspreads model is null");
            }

            var result = await _curtainsContext.Bedspreads.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> BedspreadsModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > BedspreadsModel type</param>
        public async Task UpdateAsync(BedspreadsModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Bedspreads.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> BedspreadsModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > BedspreadsModel type</param>
        public async Task RemoveAsync(BedspreadsModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Bedspreads model is null");
                throw new ArgumentNullException("Bedspreads model is null");
            }

            _curtainsContext.Bedspreads.Remove(entity);
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
