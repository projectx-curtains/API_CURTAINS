using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> DecorationsRepository</c> describes entity interaction model for database
    /// </summary>
    public class DecorationsRepository : IDecorationsRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<DecorationsModel> Query => _curtainsContext.Decorations.Include(x => x.Fabrics);
        #endregion

        public DecorationsRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> DecorationsModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of DecorationsModel entities in List Decorations</return>
        public IEnumerable<DecorationsModel> GetAll()
        {
            return _curtainsContext.Decorations.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> DecorationsModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Decorationss entity idetifier</param>
        /// <returns>Decorations model</return>
        public async Task<DecorationsModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Decorations model is null");
                throw new ArgumentNullException("Decorations model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> DecorationsModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > DecorationsModel Decorations</param>
        /// <returns>EntityEntry<DecorationsModel></return>
        public async Task<EntityEntry<DecorationsModel>> InsertAsync(DecorationsModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Decorations model is null");
                throw new ArgumentNullException("Decorations model is null");
            }

            var result = await _curtainsContext.Decorations.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> DecorationsModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > DecorationsModel Decorations</param>
        public async Task UpdateAsync(DecorationsModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Decorations.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> DecorationsModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > DecorationsModel Decorations</param>
        public async Task RemoveAsync(DecorationsModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Decorations model is null");
                throw new ArgumentNullException("Decorations model is null");
            }

            _curtainsContext.Decorations.Remove(entity);
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
