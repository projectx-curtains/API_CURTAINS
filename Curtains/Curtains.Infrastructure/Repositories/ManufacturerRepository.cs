using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> ManufacturerRepository</c> describes entity interaction model for database
    /// </summary>
    public class ManufacturerRepository : IManufacturerRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<ManufacturerModel> Query => _curtainsContext.Manufacturers.Include(x => x.Fabrics);
        #endregion

        public ManufacturerRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> ManufacturerModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of ManufacturerModel entities in List Manufacturer</return>
        public IEnumerable<ManufacturerModel> GetAll()
        {
            return _curtainsContext.Manufacturers.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> ManufacturerModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Manufacturers entity idetifier</param>
        /// <returns>Manufacturer model</return>
        public async Task<ManufacturerModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Manufacturer model is null");
                throw new ArgumentNullException("Manufacturer model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> ManufacturerModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > ManufacturerModel Manufacturer</param>
        /// <returns>EntityEntry<ManufacturerModel></return>
        public async Task<EntityEntry<ManufacturerModel>> InsertAsync(ManufacturerModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Manufacturer model is null");
                throw new ArgumentNullException("Manufacturer model is null");
            }

            var result = await _curtainsContext.Manufacturers.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> ManufacturerModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > ManufacturerModel Manufacturer</param>
        public async Task UpdateAsync(ManufacturerModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Manufacturers.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> ManufacturerModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > ManufacturerModel Manufacturer</param>
        public async Task RemoveAsync(ManufacturerModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Manufacturer model is null");
                throw new ArgumentNullException("Manufacturer model is null");
            }

            _curtainsContext.Manufacturers.Remove(entity);
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
