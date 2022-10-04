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
    /// Class<c> ConsistencyRepository</c> describes entity interaction model for database
    /// </summary>
    public class ConsistencyRepository : IConsistencyRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<ConsistencyModel> Query => _curtainsContext.Consistencies.Include(x => x.Fabrics);
        #endregion

        public ConsistencyRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> ConsistencyModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of ConsistencyModel entities in List type</return>
        public IEnumerable<ConsistencyModel> GetAll()
        {
            return _curtainsContext.Consistencies.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> ConsistencyModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>Consistency model</return>
        public async Task<ConsistencyModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Consistency model is null");
                throw new ArgumentNullException("Consistency model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> ConsistencyModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > ConsistencyModel type</param>
        /// <returns>EntityEntry<ConsistencyModel></return>
        public async Task<EntityEntry<ConsistencyModel>> InsertAsync(ConsistencyModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Consistency model is null");
                throw new ArgumentNullException("Consistency model is null");
            }

            var result = await _curtainsContext.Consistencies.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> ConsistencyModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > ConsistencyModel type</param>
        public async void UpdateAsync(ConsistencyModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Consistencies.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> ConsistencyModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > ConsistencyModel type</param>
        public async void RemoveAsync(ConsistencyModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Consistency model is null");
                throw new ArgumentNullException("Consistency model is null");
            }

            _curtainsContext.Consistencies.Remove(entity);
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
