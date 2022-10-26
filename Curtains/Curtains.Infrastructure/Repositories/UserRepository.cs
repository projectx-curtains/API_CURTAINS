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
    /// Class<c> UserRepository</c> describes entity interaction model for database
    /// </summary>
    public class UserRepository : IUserRepository
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<UserModel> Query => _curtainsContext.Users.Include(x => x.Orders).Include(x => x.UserOrders);
        #endregion

        public UserRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> UserModel <c> entities from database with includes tabels by entity Id
        /// </summary>
        /// <returns>Collection of UserModel entities in List User</return>
        public IEnumerable<UserModel> GetAll()
        {
            return _curtainsContext.Users.AsNoTracking().AsEnumerable();
        }

        /// <summary>
        /// This method get <c> UserModel <c> entity from database by entity Id
        /// </summary>
        /// <param name = "Id" > Guid Users entity idetifier</param>
        /// <returns>User model</return>
        public async Task<UserModel> GetByIdAsync(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result == null)
            {
                _logger.LogError("User model is null");
                throw new ArgumentNullException("User model is null");
            }

            return result;
        }

        /// <summary>
        /// This method add <c> UserModel <c> entity to database
        /// </summary>
        /// <param name = "entity" > UserModel User</param>
        /// <returns>EntityEntry<UserModel></return>
        public async Task<EntityEntry<UserModel>> InsertAsync(UserModel entity, CancellationToken cancelationToken)
        {
            if (entity == null)
            {
                _logger.LogError("User model is null");
                throw new ArgumentNullException("User model is null");
            }

            var result = await _curtainsContext.Users.AddAsync(entity, cancelationToken);

            await _curtainsContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// This method update <c> UserModel <c> entity in database 
        /// </summary>
        /// <param name = "entity" > UserModel User</param>
        public async Task UpdateAsync(UserModel entity)
        {
            foreach (var entry in _curtainsContext.ChangeTracker.Entries())
            {
                var entryEntity = (Entity)entry.Entity;
                if (entryEntity.IsNew)
                {
                    entryEntity.State = EntityState.Added;
                }
            }

            _curtainsContext.Users.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method remove <c> UserModel <c> entity from database 
        /// </summary>
        /// <param name = "entity" > UserModel User</param>
        public async Task RemoveAsync(UserModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("User model is null");
                throw new ArgumentNullException("User model is null");
            }

            _curtainsContext.Users.Remove(entity);
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
