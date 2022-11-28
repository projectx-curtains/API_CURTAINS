using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> FabricRepository</c> describes entity interaction model for database
    /// </summary>
    public class FabricRepository : IFabricRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<FabricModel> Query => _curtainsContext.Fabrics.Include(x => x.Curtains).Include(x => x.Bedspreads).Include(x => x.Pillows);
        #endregion

        public FabricRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> FabricModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of FabricModel entities in List Fabric</return>
        public IEnumerable<FabricModel> GetAll()
        {
            return _curtainsContext.Fabrics.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> FabricModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Fabrics entity idetifier</param>
        /// <returns>Fabric model</return>
        public async Task<FabricModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Fabric model is null");
                throw new ArgumentNullException("Fabric model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> FabricModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > FabricModel Fabric</param>
        /// <returns>EntityEntry<FabricModel></return>
        public async Task<EntityEntry<FabricModel>> InsertAsync(FabricModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Fabric model is null");
                throw new ArgumentNullException("Fabric model is null");
            }

            var result = await _curtainsContext.Fabrics.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> FabricModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > FabricModel Fabric</param>
        public async Task UpdateAsync(FabricModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Fabrics.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> FabricModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > FabricModel Fabric</param>
        public async Task RemoveAsync(FabricModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Fabric model is null");
                throw new ArgumentNullException("Fabric model is null");
            }

            _curtainsContext.Fabrics.Remove(entity);
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
