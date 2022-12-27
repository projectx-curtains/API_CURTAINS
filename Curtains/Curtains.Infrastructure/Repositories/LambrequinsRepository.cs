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
    /// Class<c> LambrequinsRepository</c> describes entity interaction model for database
    /// </summary>
    public class LambrequinsRepository : ILambrequinsRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<LambrequinsModel> Query => _curtainsContext.Lambrequins;
        #endregion

        public LambrequinsRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> LambrequinsModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of LambrequinsModel entities in List Lambrequins</return>
        public IEnumerable<LambrequinsModel> GetAll()
        {
            if (!_curtainsContext.Lambrequins.Any())
            {
                _logger.LogError("Lambrequins table is empty");
                throw new ResourceNotFoundException();
            }

            return _curtainsContext.Lambrequins.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> LambrequinsModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Lambrequinss entity idetifier</param>
        /// <returns>Lambrequins model</return>
        public async Task<LambrequinsModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Lambrequins model is null");
                throw new ArgumentNullException("Lambrequins model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> LambrequinsModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > LambrequinsModel Lambrequins</param>
        /// <returns>EntityEntry<LambrequinsModel></return>
        public async Task<EntityEntry<LambrequinsModel>> InsertAsync(LambrequinsModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Lambrequins model is null");
                throw new ArgumentNullException("Lambrequins model is null");
            }

            var result = await _curtainsContext.Lambrequins.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> LambrequinsModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > LambrequinsModel Lambrequins</param>
        public async Task UpdateAsync(LambrequinsModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Lambrequins.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> LambrequinsModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > LambrequinsModel Lambrequins</param>
        public async Task RemoveAsync(LambrequinsModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Lambrequins model is null");
                throw new ArgumentNullException("Lambrequins model is null");
            }

            _curtainsContext.Lambrequins.Remove(entity);
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
