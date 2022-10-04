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
    /// Class<c> UserOrderRepository</c> describes entity interaction model for database
    /// </summary>
    public class UserOrderRepository : IUserOrderRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<UserOrderModel> Query => _curtainsContext.UserOrders;
        #endregion

        public UserOrderRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> UserOrderModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of UserOrderModel entities in List UserOrder</return>
        public IEnumerable<UserOrderModel> GetAll()
        {
            return _curtainsContext.UserOrders.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> UserOrderModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid UserOrders entity idetifier</param>
        /// <returns>UserOrder model</return>
        public async Task<UserOrderModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("UserOrder model is null");
                throw new ArgumentNullException("UserOrder model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> UserOrderModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > UserOrderModel UserOrder</param>
        /// <returns>EntityEntry<UserOrderModel></return>
        public async Task<EntityEntry<UserOrderModel>> InsertAsync(UserOrderModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("UserOrder model is null");
                throw new ArgumentNullException("UserOrder model is null");
            }

            var result = await _curtainsContext.UserOrders.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> UserOrderModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > UserOrderModel UserOrder</param>
        public async void UpdateAsync(UserOrderModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.UserOrders.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> UserOrderModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > UserOrderModel UserOrder</param>
        public async void RemoveAsync(UserOrderModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("UserOrder model is null");
                throw new ArgumentNullException("UserOrder model is null");
            }

            _curtainsContext.UserOrders.Remove(entity);
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
