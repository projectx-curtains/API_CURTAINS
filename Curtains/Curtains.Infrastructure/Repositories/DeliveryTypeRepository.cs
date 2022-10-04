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
    /// Class<c> DeliveryTypeRepository</c> describes entity interaction model for database
    /// </summary>
    public class DeliveryTypeRepository : IDeliveryTypeRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<DeliveryTypeModel> Query => _curtainsContext.DeliveryTypes.Include(x => x.Orders);
        #endregion

        public DeliveryTypeRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> DeliveryTypeModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of DeliveryTypeModel entities in List DeliveryType</return>
        public IEnumerable<DeliveryTypeModel> GetAll()
        {
            return _curtainsContext.DeliveryTypes.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> DeliveryTypeModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid DeliveryTypes entity idetifier</param>
        /// <returns>DeliveryType model</return>
        public async Task<DeliveryTypeModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("DeliveryType model is null");
                throw new ArgumentNullException("DeliveryType model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> DeliveryTypeModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > DeliveryTypeModel DeliveryType</param>
        /// <returns>EntityEntry<DeliveryTypeModel></return>
        public async Task<EntityEntry<DeliveryTypeModel>> InsertAsync(DeliveryTypeModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("DeliveryType model is null");
                throw new ArgumentNullException("DeliveryType model is null");
            }

            var result = await _curtainsContext.DeliveryTypes.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> DeliveryTypeModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > DeliveryTypeModel DeliveryType</param>
        public async void UpdateAsync(DeliveryTypeModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.DeliveryTypes.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> DeliveryTypeModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > DeliveryTypeModel DeliveryType</param>
        public async void RemoveAsync(DeliveryTypeModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("DeliveryType model is null");
                throw new ArgumentNullException("DeliveryType model is null");
            }

            _curtainsContext.DeliveryTypes.Remove(entity);
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
