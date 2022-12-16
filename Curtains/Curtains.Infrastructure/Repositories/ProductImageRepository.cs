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
    /// Class<c> ProductImageRepository</c> describes entity interaction model for database
    /// </summary>
    public class ProductImageRepository : IProductImageRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<ProductImageModel> Query => _curtainsContext.ProductImages.Include(x => x.Curtains).Include(x => x.Pillows)
                    .Include(x => x.Bedspreads).Include(x => x.Sets).Include(x => x.Fabrics).Include(x => x.MarketingInfo);
        #endregion

        public ProductImageRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> ProductImageModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of ProductImageModel entities in List ProductImage</return>
        public IEnumerable<ProductImageModel> GetAll()
        {
            if (!_curtainsContext.ProductImages.Any())
            {
                _logger.LogError("Product images table is empty");
                throw new ResourceNotFoundException();
            }

            return _curtainsContext.ProductImages.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> ProductImageModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid ProductImages entity idetifier</param>
        /// <returns>ProductImage model</return>
        public async Task<ProductImageModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("ProductImage model is null");
                throw new ArgumentNullException("ProductImage model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> ProductImageModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > ProductImageModel ProductImage</param>
        /// <returns>EntityEntry<ProductImageModel></return>
        public async Task<EntityEntry<ProductImageModel>> InsertAsync(ProductImageModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("ProductImage model is null");
                throw new ArgumentNullException("ProductImage model is null");
            }

            var result = await _curtainsContext.ProductImages.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> ProductImageModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > ProductImageModel ProductImage</param>
        public async Task UpdateAsync(ProductImageModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.ProductImages.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> ProductImageModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > ProductImageModel ProductImage</param>
        public async Task RemoveAsync(ProductImageModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("ProductImage model is null");
                throw new ArgumentNullException("ProductImage model is null");
            }

            _curtainsContext.ProductImages.Remove(entity);
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
