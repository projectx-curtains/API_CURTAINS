using Curtains.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<ReviewModel> GetAll();
        Task<ReviewModel> GetByIdAsync(int Id);
        Task<EntityEntry<ReviewModel>> InsertAsync(ReviewModel entity, CancellationToken cancellationToken);
        void UpdateAsync(ReviewModel entity);
        void RemoveAsync(ReviewModel entity);
        void SaveChangesAsync();
    }
}
