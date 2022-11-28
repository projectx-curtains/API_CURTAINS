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
    /// Class<c> ColorRepository</c> describes entity interaction model for database
    /// </summary>
    public class ColorRepository : IColorRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<ColorModel> Query => _curtainsContext.Colors.Include(x => x.Fabrics).Include(x => x.Accessories);
        #endregion

        public ColorRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> ColorModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of ColorModel entities in List type</return>
        public IEnumerable<ColorModel> GetAll()
        {
            return _curtainsContext.Colors.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> ColorModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid types entity idetifier</param>
        /// <returns>Color model</return>
        public async Task<ColorModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("Color model is null");
                throw new ArgumentNullException("Color model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> ColorModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > ColorModel type</param>
        /// <returns>EntityEntry<ColorModel></return>
        public async Task<EntityEntry<ColorModel>> InsertAsync(ColorModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("Color model is null");
                throw new ArgumentNullException("Color model is null");
            }

            var result = await _curtainsContext.Colors.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> ColorModel <c> entity in database
        /// </summary>
        /// <param name = "entity" > ColorModel type</param>
        public async Task UpdateAsync(ColorModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Colors.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> ColorModel <c> entity from database
        /// </summary>
        /// <param name = "entity" > ColorModel type</param>
        public async Task RemoveAsync(ColorModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Color model is null");
                throw new ArgumentNullException("Color model is null");
            }

            _curtainsContext.Colors.Remove(entity);
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
