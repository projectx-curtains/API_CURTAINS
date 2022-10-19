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
    /// <summary>
    /// Class <c> ReviewService </c> a default implementetion of <c> IReviewService </c>
    /// </summary>
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

        /// <summary>
        /// This method get all<c> ReviewModel <c> entities 
        /// from database and mapping to <c> ReviewDTO </c>
        /// </summary>
        /// <returns>Collection of ReviewDTO entities in list Review</returns>
        public IEnumerable<ReviewDTO> GetAll()
        {
            var reviews = _mapper.Map<IEnumerable<ReviewDTO>>(_reviewRepository.GetAll());
            return reviews;
        }

        /// <summary>
        /// This method get <c> ReviewModel <c> entity 
        /// from database by entity Id and mapping to <c> ReviewDTO </c>
        /// </summary>
        /// <param name="Id"> Guid Reviews entity idetifier </param>
        /// <returns> ReviewDTO </returns>
        public async Task<ReviewDTO> GetByIdAsync(int Id)
        {
            var review = await _reviewRepository.GetByIdAsync(Id);
            var reviewDTO = _mapper.Map<ReviewDTO>(review);
            return reviewDTO;
        }

        /// <summary>
        /// This method accepts <c> ReviewDTO </c> entity and mapping to 
        /// <c> ReviewModel </c> then pushed to Review repository for add to database
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <param name="cancelationToken"></param>
        /// <returns> Task </returns>
        public async Task InsertAsync(ReviewDTO entity, CancellationToken cancelationToken)
        {
            var review = MapToModel(entity);
            await _reviewRepository.InsertAsync(review, cancelationToken);
        }

        /// <summary>
        /// This method accepts <c> ReviewDTO </c> entity and mapping 
        /// to <c> ReviewModel </c> then pushed to Review repository for update to database
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> Task </returns>
        public async Task UpdateAsync(ReviewDTO entity)
        {
            var review = MapToModel(entity);
            await _reviewRepository.UpdateAsync(review);
        }

        /// <summary>
        /// This method accepts <c> ReviewDTO </c> entity and mapping 
        /// to <c> ReviewModel </c> then pushed to Review repository for remove entity to database
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> Task </returns>
        public async Task RemoveAsync(ReviewDTO entity)
        {
            var review = MapToModel(entity);
            await _reviewRepository.RemoveAsync(review);
        }

        /// <summary>
        /// This method accepts <c> ReviewDTO </c> and mapping to <c> ReviewModel </c>
        /// </summary>
        /// <param name="entity"> ReviewDTO Review </param>
        /// <returns> ReviewModel </returns>
        private ReviewModel MapToModel(ReviewDTO entity)
        {
            var review = _mapper.Map<ReviewModel>(entity);
            return review;
        }
        #endregion
    }
}
