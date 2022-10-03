using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public class AccessoriesRepository : IRepository<AccessoriesModel>
    {
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private IQueryable<AccessoriesModel> Query => _curtainsContext.Accessories.Include(x => x.Curtains).Include(x => x.UserOrders);

        public AccessoriesRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
        }

        public IEnumerable<AccessoriesModel> GetAll()
        {
            return _curtainsContext.Accessories.AsNoTracking().AsEnumerable();
        }

        public async Task<AccessoriesModel> GetById(int Id)
        {
            var result = await Query.AsNoTracking().SingleOrDefaultAsync(a => a.Id == Id);

            if (result != null)
                return result;

            return null;
        }

        public async void Insert(AccessoriesModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            await _curtainsContext.Accessories.AddAsync(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        public async void Update(AccessoriesModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }
            foreach (var entry in _curtainsContext.ChangeTracker.Entries()) 
            { 
                var entryEntity = (Entity)entry.Entity; 
                if (entryEntity.IsNew) 
                {
                    entryEntity.State = EntityState.Added; 
                } 
            }

            _curtainsContext.Accessories.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        public async void Remove(AccessoriesModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            _curtainsContext.Accessories.Remove(entity);
            await _curtainsContext.SaveChangesAsync();
        }

        public async void SaveChanges()
        {
            await _curtainsContext.SaveChangesAsync();
        }
    }
}
