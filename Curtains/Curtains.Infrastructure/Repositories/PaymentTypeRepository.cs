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
    /// Class<c> PaymentTypeRepository</c> describes entity interaction model for database
    /// </summary>
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<PaymentTypeModel> Query => _curtainsContext.PaymentTypes.Include(x => x.Orders);
        #endregion

        public PaymentTypeRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> PaymentTypeModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of PaymentTypeModel entities in List PaymentType</return>
        public IEnumerable<PaymentTypeModel> GetAll()
        {
            return _curtainsContext.PaymentTypes.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> PaymentTypeModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid PaymentTypes entity idetifier</param>
        /// <returns>PaymentType model</return>
        public async Task<PaymentTypeModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("PaymentType model is null");
                throw new ArgumentNullException("PaymentType model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> PaymentTypeModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > PaymentTypeModel PaymentType</param>
        /// <returns>EntityEntry<PaymentTypeModel></return>
        public async Task<EntityEntry<PaymentTypeModel>> InsertAsync(PaymentTypeModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("PaymentType model is null");
                throw new ArgumentNullException("PaymentType model is null");
            }

            var result = await _curtainsContext.PaymentTypes.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> PaymentTypeModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > PaymentTypeModel PaymentType</param>
        public async Task UpdateAsync(PaymentTypeModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.PaymentTypes.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> PaymentTypeModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > PaymentTypeModel PaymentType</param>
        public async Task RemoveAsync(PaymentTypeModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("PaymentType model is null");
                throw new ArgumentNullException("PaymentType model is null");
            }

            _curtainsContext.PaymentTypes.Remove(entity);
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
