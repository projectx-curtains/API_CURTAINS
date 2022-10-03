using Curtains.Application.Interfaces;
using Curtains.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Curtains.Application.DTO;
using AutoMapper;
using Curtains.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly CurtainsDbContext _context;
        private readonly IMapper _mapper;

        public ReviewService(CurtainsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ReviewDTO>> GetAllReview()
        {
            List<ReviewDTO> listReviewDTO = new();
            var listReview = await _context.Reviews.ToListAsync();
            foreach (var item in listReview)
            {
                var list = _mapper.Map<ReviewDTO>(item);
                listReviewDTO.Add(list);
            }
            return listReviewDTO;
        }

        public async Task AddReview(ReviewDTO reviewDTO)
        {
            ReviewModel review = _mapper.Map<ReviewModel>(reviewDTO);
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveReview(int reviewId)
        {
            var review = await _context.Reviews.FirstOrDefaultAsync(r => r.Id == reviewId);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
        }
    }
}
