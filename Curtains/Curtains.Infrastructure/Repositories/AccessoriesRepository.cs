using Curtains.Domain.Models;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public class AccessoriesRepository
    {
        private readonly ILogger _logger;
        private readonly CurtainsDbContext _curtainsContext;
        private DbSet<AccessoriesModel> accessories;

        public AccessoriesRepository(CurtainsDbContext curtainsContext, ILogger logger)
        {
            _curtainsContext = curtainsContext;
            _logger = logger;
            accessories = _curtainsContext.Accessories;
        }

        public IEnumerable<AccessoriesModel> GetAll()
        {
            return accessories.AsEnumerable();
        }

        public async Task<AccessoriesModel> GetById(int Id)
        {
            return await accessories.SingleAsync(c => c.Id == Id);
        }

        public async void Insert(AccessoriesModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            await accessories.AddAsync(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        public async void Update(AccessoriesModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            accessories.Update(entity);

            await _curtainsContext.SaveChangesAsync();
        }

        public async void Remove(AccessoriesModel entity)
        {
            if (entity == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ArgumentNullException("Accessories model is null");
            }

            accessories.Remove(entity);
            await _curtainsContext.SaveChangesAsync();
        }

        public async void SaveChanges()
        {
            await _curtainsContext.SaveChangesAsync();
        }
    }
}
