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
using Curtains.Infrastructure.Shared.Exceptions;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> PillowsRepository</c> describes entity interaction model for database
    /// </summary>
    public class PillowsRepository : IPillowsRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<PillowsModel> Query => _curtainsContext.Pillows.Include(x => x.ProductSets);
        #endregion

        public PillowsRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> PillowsModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of PillowsModel entities in List Pillows</return>
        public IEnumerable<PillowsModel> GetAll()
        {
            if (!_curtainsContext.Pillows.Any())
            {
                _logger.LogError("Pillows table is empty");
                throw new ResourceNotFoundException();
            }

            return _curtainsContext.Pillows.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> PillowsModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Pillowss entity idetifier</param>
        /// <returns>Pillows model</return>
        public async Task<PillowsModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Pillows model is null");
                throw new ArgumentNullException("Pillows model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> PillowsModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > PillowsModel Pillows</param>
        /// <returns>EntityEntry<PillowsModel></return>
        public async Task<EntityEntry<PillowsModel>> InsertAsync(PillowsModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Pillows model is null");
                throw new ArgumentNullException("Pillows model is null");
            }

            var result = await _curtainsContext.Pillows.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> PillowsModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > PillowsModel Pillows</param>
        public async Task UpdateAsync(PillowsModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Pillows.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> PillowsModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > PillowsModel Pillows</param>
        public async Task RemoveAsync(PillowsModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Pillows model is null");
                throw new ArgumentNullException("Pillows model is null");
            }

            _curtainsContext.Pillows.Remove(entity);
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
