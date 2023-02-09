using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Shared.Exceptions;

namespace Curtains.Infrastructure.Repositories
{
    /// <summary>
    /// Class<c> ProductSetRepository</c> describes entity interaction model for database
    /// </summary>
    public class ProductSetRepository : IProductSetRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<ProductSetModel> Query => _curtainsContext.ProductSets;
        #endregion

        public ProductSetRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> ProductSetModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of ProductSetModel entities in List ProductSet</return>
        public IEnumerable<ProductSetModel> GetAll()
        {
            if (!_curtainsContext.ProductSets.Any())
            {
                _logger.LogError("Product set table is empty");
                throw new ResourceNotFoundException();
            }

            return _curtainsContext.ProductSets.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> ProductSetModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid ProductSets entity idetifier</param>
        /// <returns>ProductSet model</return>
        public async Task<ProductSetModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("ProductSet model is null");
                throw new ArgumentNullException("ProductSet model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> ProductSetModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > ProductSetModel ProductSet</param>
        /// <returns>EntityEntry<ProductSetModel></return>
        public async Task<EntityEntry<ProductSetModel>> InsertAsync(ProductSetModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("ProductSet model is null");
                throw new ArgumentNullException("ProductSet model is null");
            }

            var result = await _curtainsContext.ProductSets.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> ProductSetModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > ProductSetModel ProductSet</param>
        public async Task UpdateAsync(ProductSetModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.ProductSets.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> ProductSetModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > ProductSetModel ProductSet</param>
        public async Task RemoveAsync(ProductSetModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("ProductSet model is null");
                throw new ArgumentNullException("ProductSet model is null");
            }

            _curtainsContext.ProductSets.Remove(entity);
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
