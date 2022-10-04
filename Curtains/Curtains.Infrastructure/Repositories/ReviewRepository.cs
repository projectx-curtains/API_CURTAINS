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
    /// Class<c> ReviewRepository</c> describes entity interaction model for database
    /// </summary>
    public class ReviewRepository : IReviewRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<ReviewModel> Query => _curtainsContext.Reviews;
        #endregion

        public ReviewRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> ReviewModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of ReviewModel entities in List Review</return>
        public IEnumerable<ReviewModel> GetAll()
        {
            return _curtainsContext.Reviews.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> ReviewModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Reviews entity idetifier</param>
        /// <returns>Review model</return>
        public async Task<ReviewModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Review model is null");
                throw new ArgumentNullException("Review model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> ReviewModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > ReviewModel Review</param>
        /// <returns>EntityEntry<ReviewModel></return>
        public async Task<EntityEntry<ReviewModel>> InsertAsync(ReviewModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Review model is null");
                throw new ArgumentNullException("Review model is null");
            }

            var result = await _curtainsContext.Reviews.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> ReviewModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > ReviewModel Review</param>
        public async void UpdateAsync(ReviewModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Reviews.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> ReviewModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > ReviewModel Review</param>
        public async void RemoveAsync(ReviewModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Review model is null");
                throw new ArgumentNullException("Review model is null");
            }

            _curtainsContext.Reviews.Remove(entity);
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
