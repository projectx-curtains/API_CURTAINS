using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curtains.Application.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Curtains.Application.CurtainsService
{
    public class ReviewServicev : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly CurtainsDbContext _context;

        public ReviewServicev(IReviewRepository reviewRepository, CurtainsDbContext context)
        {
            _reviewRepository = reviewRepository;
            _context = context;
        }

        public IEnumerable<ReviewDTO> GetAll()
        {

        }

        public async Task<ReviewDTO> GetByIdAsync(int Id)
        {

        }

        public async Task<EntityEntry<ReviewDTO>> InsertAsync(ReviewDTO entity, CancellationToken cancelationToken)
        {

        }

        public async void UpdateAsync(ReviewDTO entity)
        {

        }

        public async void RemoveAsync(ReviewDTO entity)
        {

        }

    }
}
