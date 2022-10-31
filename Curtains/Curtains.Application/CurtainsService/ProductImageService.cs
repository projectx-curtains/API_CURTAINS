﻿using AutoMapper;
using Curtains.Application.CurtainsServices.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsServices
{
    /// <summary>
    /// Class <c> ProductImageService </c> describes the interaction model of the data transfer object to the database.
    /// </summary>
    public class ProductImageService : IProductImageService
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;
        #endregion

        public ProductImageService(IProductImageRepository productImageRepository, IMapper mapper, ILogger logger)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
            _logger = logger;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all<c> ProductImageModel <c> entities from database and mapping to <c> ProductImageDTO </c>
        /// </summary>
        /// <returns>Collection of ProductImageDTO entities in list Review</returns>
        public IEnumerable<ProductImageDTO> GetAll()
        {
            var productImages = _mapper.Map<IEnumerable<ProductImageDTO>>(_productImageRepository.GetAll());

            if (productImages == null)
            {
                return new List<ProductImageDTO>();
            }
            return productImages;
        }

        /// <summary>
        /// This method get all new <c> ProductImageModel <c> entities from database and mapping to <c> ProductImageDTO </c>
        /// </summary>
        /// <returns>Collection of ProductImageDTO entities in list Review</returns>
        public IEnumerable<ProductImageDTO> GetNewItems()
        {
            var newProductImages = _mapper.Map<IEnumerable<ProductImageDTO>>(_productImageRepository.GetAll()).Where(p => p.MarketingInfo.IsNew);

            if (newProductImages == null)
            {
                return new List<ProductImageDTO>();
            }
            return newProductImages;
        }

        /// <summary>
        /// This method get all popular <c> ProductImageModel <c> entities from database and mapping to <c> ProductImageDTO </c>
        /// </summary>
        /// <returns>Collection of ProductImageDTO entities in list Review</returns>
        public IEnumerable<ProductImageDTO> GetPopularItems()
        {
            var popularProductImages = _mapper.Map<IEnumerable<ProductImageDTO>>(_productImageRepository.GetAll()).Where(p => p.MarketingInfo.IsPopular);

            if (popularProductImages == null)
            {
                return new List<ProductImageDTO>();
            }
            return popularProductImages;
        }

        /// <summary>
        /// This method get <c> ProductImageModel <c> entity from database by entity Id and mapping to <c> ProductImageDTO </c>
        /// </summary>
        /// <param name="Id"> Guid ProductImage entity idetifier </param>
        /// <returns> ProductImageDTO </returns>
        public async Task<ProductImageDTO> GetByIdAsync(int Id)
        {
            var productImage = await _productImageRepository.GetByIdAsync(Id);
            if (productImage == null)
            {
                _logger.LogError("ProductImage model is null");
                throw new ArgumentNullException("ProductImage model is null");
            }
            var productImageDTO = _mapper.Map<ProductImageDTO>(productImage);
            return productImageDTO;
        }

        /// <summary>
        /// This method accepts <c> ProductImageDTO </c> entity and mapping to <c> ProductImageModel </c> then pushed to ProductImage repository for add to database
        /// </summary>
        /// <param name="entity"> ProductImageDTO ProductImage </param>
        /// <param name="cancelationToken"></param>
        /// <returns> Task </returns>
        public async Task InsertAsync(ProductImageDTO entity, CancellationToken cancelationToken)
        {
            var productImage = MapToModel(entity);
            await _productImageRepository.InsertAsync(productImage, cancelationToken);
        }

        /// <summary>
        /// This method accepts <c> ProductImageDTO </c> entity and mapping to <c> ProductImageModel </c> then pushed to ProductImage repository for update to database
        /// </summary>
        /// <param name="entity"> ProductImageDTO ProductImage </param>
        /// <returns> Task </returns>
        public async Task UpdateAsync(ProductImageDTO entity)
        {
            var review = MapToModel(entity);
            await _productImageRepository.UpdateAsync(review);
        }

        /// <summary>
        /// This method accepts <c> ProductImageDTO </c> entity and mapping to <c> ProductImageModel </c> then pushed to ProductImage repository for remove entity to database
        /// </summary>
        /// <param name="entity"> ProductImageDTO ProductImage </param>
        /// <returns> Task </returns>
        public async Task RemoveAsync(ProductImageDTO entity)
        {
            var review = MapToModel(entity);
            await _productImageRepository.RemoveAsync(review);
        }

        /// <summary>
        /// This method accepts <c> ProductImageDTO </c> and mapping to <c> ProductImageModel </c>
        /// </summary>
        /// <param name="entity"> ProductImageDTO ProductImage </param>
        /// <returns> ProductImageModel </returns>
        private ProductImageModel MapToModel(ProductImageDTO entity)
        {
            var productImage = _mapper.Map<ProductImageModel>(entity);
            return productImage;
        }
        #endregion
    }
}