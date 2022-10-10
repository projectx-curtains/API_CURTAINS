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
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Curtains.Application.CurtainsService
{
    public class ReviewService : IReviewService
    {
        #region FieldsRegion
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;
        #endregion

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        #region MethodsRegion
        public IEnumerable<ReviewDTO> GetAll()
        {
            var reviews = _mapper.Map<IEnumerable<ReviewDTO>>(_reviewRepository.GetAll());
            return reviews;
        }

        public async Task<ReviewDTO> GetByIdAsync(int Id)
        {
            var review = await _reviewRepository.GetByIdAsync(Id);
            var reviewDTO = _mapper.Map<ReviewDTO>(review);
            return reviewDTO;
        }

        public async Task InsertAsync(ReviewDTO entity, CancellationToken cancelationToken)
        {
            var review = MappingToModel(entity);
            await _reviewRepository.InsertAsync(review, cancelationToken);
        }

        public async Task UpdateAsync(ReviewDTO entity)
        {
            var review = MappingToModel(entity);
            await _reviewRepository.UpdateAsync(review);
        }

        public async Task RemoveAsync(ReviewDTO entity)
        {
            var review = MappingToModel(entity);
            await _reviewRepository.RemoveAsync(review);
        }

        private ReviewModel MappingToModel(ReviewDTO entity)
        {
            var review = _mapper.Map<ReviewModel>(entity);
            return review;
        }
        #endregion
    }
}
