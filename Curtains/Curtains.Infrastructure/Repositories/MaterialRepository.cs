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
    /// Class<c> MaterialRepository</c> describes entity interaction model for database
    /// </summary>
    public class MaterialRepository : IMaterialRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<MaterialModel> Query => _curtainsContext.Materials.Include(x => x.Curtains);
        #endregion

        public MaterialRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> MaterialModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of MaterialModel entities in List Material</return>
        public IEnumerable<MaterialModel> GetAll()
        {
            return _curtainsContext.Materials.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> MaterialModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Materials entity idetifier</param>
        /// <returns>Material model</return>
        public async Task<MaterialModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Material model is null");
                throw new ArgumentNullException("Material model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> MaterialModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > MaterialModel Material</param>
        /// <returns>EntityEntry<MaterialModel></return>
        public async Task<EntityEntry<MaterialModel>> InsertAsync(MaterialModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Material model is null");
                throw new ArgumentNullException("Material model is null");
            }

            var result = await _curtainsContext.Materials.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> MaterialModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > MaterialModel Material</param>
        public async Task UpdateAsync(MaterialModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Materials.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> MaterialModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > MaterialModel Material</param>
        public async Task RemoveAsync(MaterialModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Material model is null");
                throw new ArgumentNullException("Material model is null");
            }

            _curtainsContext.Materials.Remove(entity);
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
