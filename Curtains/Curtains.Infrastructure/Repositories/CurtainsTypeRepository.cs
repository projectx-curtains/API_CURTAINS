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
    /// Class<c> CurtainsTypeRepository</c> describes entity interaction model for database
    /// </summary>
    public class CurtainsTypeRepository : ICurtainsTypeRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<CurtainsTypeModel> Query => _curtainsContext.CurtainsTypes.Include(x => x.Curtains);
        #endregion

        public CurtainsTypeRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> CurtainsTypeModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of CurtainsTypeModel entities in List CurtainsType</return>
        public IEnumerable<CurtainsTypeModel> GetAll()
        {
            return _curtainsContext.CurtainsTypes.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> CurtainsTypeModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid CurtainsTypes entity idetifier</param>
        /// <returns>CurtainsType model</return>
        public async Task<CurtainsTypeModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("CurtainsType model is null");
                throw new ArgumentNullException("CurtainsType model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> CurtainsTypeModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > CurtainsTypeModel CurtainsType</param>
        /// <returns>EntityEntry<CurtainsTypeModel></return>
        public async Task<EntityEntry<CurtainsTypeModel>> InsertAsync(CurtainsTypeModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("CurtainsType model is null");
                throw new ArgumentNullException("CurtainsType model is null");
            }

            var result = await _curtainsContext.CurtainsTypes.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> CurtainsTypeModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > CurtainsTypeModel CurtainsType</param>
        public async Task UpdateAsync(CurtainsTypeModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.CurtainsTypes.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> CurtainsTypeModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > CurtainsTypeModel CurtainsType</param>
        public async Task RemoveAsync(CurtainsTypeModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("CurtainsType model is null");
                throw new ArgumentNullException("CurtainsType model is null");
            }

            _curtainsContext.CurtainsTypes.Remove(entity);
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
