using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> OurWorksRepository</c> describes entity interaction model for database
    /// </summary>
    public class OurWorksRepository : IOurWorksRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<OurWorksModel> Query => _curtainsContext.OurWorks;
        #endregion

        public OurWorksRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> OurWorksModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of OurWorksModel entities in List OurWorks</return>
        public IEnumerable<OurWorksModel> GetAll()
        {
            return _curtainsContext.OurWorks.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> OurWorksModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid OurWorkss entity idetifier</param>
        /// <returns>OurWorks model</return>
        public async Task<OurWorksModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("OurWorks model is null");
                throw new ArgumentNullException("OurWorks model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> OurWorksModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > OurWorksModel OurWorks</param>
        /// <returns>EntityEntry<OurWorksModel></return>
        public async Task<EntityEntry<OurWorksModel>> InsertAsync(OurWorksModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("OurWorks model is null");
                throw new ArgumentNullException("OurWorks model is null");
            }

            var result = await _curtainsContext.OurWorks.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> OurWorksModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > OurWorksModel OurWorks</param>
        public async Task UpdateAsync(OurWorksModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.OurWorks.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> OurWorksModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > OurWorksModel OurWorks</param>
        public async Task RemoveAsync(OurWorksModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("OurWorks model is null");
                throw new ArgumentNullException("OurWorks model is null");
            }

            _curtainsContext.OurWorks.Remove(entity);
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
