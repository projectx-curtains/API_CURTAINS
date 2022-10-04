using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> AccessoriesRepository</c> describes entity interaction model for database
    /// </summary>
    public class AccessoriesRepository : IAccessoriesRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<AccessoriesModel> Query => _curtainsContext.Accessories.Include(x => x.Curtains).Include(x => x.UserOrders);
        #endregion

        public AccessoriesRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> AccessoriesModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of AccessoriesModel entities in List type</return>
        public IEnumerable<AccessoriesModel> GetAll()
        {
            return _curtainsContext.Accessories.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> AccessoriesModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>Accessories model</return>
        public async Task<AccessoriesModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> AccessoriesModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > AccessoriesModel type</param>
        /// <returns>EntityEntry<AccessoriesModel></return>
        public async Task<EntityEntry<AccessoriesModel>> InsertAsync(AccessoriesModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            var result = await _curtainsContext.Accessories.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> AccessoriesModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > AccessoriesModel type</param>
        public async void UpdateAsync(AccessoriesModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries()) 
            { 
                var entryEntity = (Entity)entry.Entity; 
                if (entryEntity.IsNew) 
                {
                    entryEntity.State = EntityState.Added; 
                } 
            }

            _curtainsContext.Accessories.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> AccessoriesModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > AccessoriesModel type</param>
        public async void RemoveAsync(AccessoriesModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            _curtainsContext.Accessories.Remove(entity);
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
