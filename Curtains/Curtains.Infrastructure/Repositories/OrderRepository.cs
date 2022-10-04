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

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> OrderRepository</c> describes entity interaction model for database
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<OrderModel> Query => _curtainsContext.Orders;
        #endregion

        public OrderRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> OrderModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of OrderModel entities in List Order</return>
        public IEnumerable<OrderModel> GetAll()
        {
            return _curtainsContext.Orders.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> OrderModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Orders entity idetifier</param>
        /// <returns>Order model</return>
        public async Task<OrderModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Order model is null");
                throw new ArgumentNullException("Order model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> OrderModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > OrderModel Order</param>
        /// <returns>EntityEntry<OrderModel></return>
        public async Task<EntityEntry<OrderModel>> InsertAsync(OrderModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Order model is null");
                throw new ArgumentNullException("Order model is null");
            }

            var result = await _curtainsContext.Orders.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> OrderModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > OrderModel Order</param>
        public async void UpdateAsync(OrderModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Orders.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> OrderModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > OrderModel Order</param>
        public async void RemoveAsync(OrderModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Order model is null");
                throw new ArgumentNullException("Order model is null");
            }

            _curtainsContext.Orders.Remove(entity);
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
