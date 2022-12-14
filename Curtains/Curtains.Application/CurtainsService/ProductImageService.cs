using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace Curtains.Application.CurtainsService
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
            return productImages ?? new List<ProductImageDTO>();
        }

        /// <summary>
        /// This method get all new <c> ProductImageModel <c> entities from database and mapping to <c> ProductImageDTO </c>
        /// </summary>
        /// <returns>Collection of ProductImageDTO entities in list Review</returns>
        public IEnumerable<ProductImageDTO> GetNewItems()
        {
            var newProductImages = _mapper.Map<IEnumerable<ProductImageDTO>>(_productImageRepository.GetAll()).Where(p => p.MarketingInfo.IsNew);
            return newProductImages ?? new List<ProductImageDTO>();
        }

        /// <summary>
        /// This method get all popular <c> ProductImageModel <c> entities from database and mapping to <c> ProductImageDTO </c>
        /// </summary>
        /// <returns>Collection of ProductImageDTO entities in list Review</returns>
        public IEnumerable<ProductImageDTO> GetPopularItems()
        {
            var popularProductImages = _mapper.Map<IEnumerable<ProductImageDTO>>(_productImageRepository.GetAll()).Where(p => p.MarketingInfo.IsPopular);
            return popularProductImages ?? new List<ProductImageDTO>();
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
            if (productImage == null)
            {
                _logger.LogError("ProductImage model is null");
                throw new ArgumentNullException("ProductImage model is null");
            }
            await _productImageRepository.InsertAsync(productImage, cancelationToken);
        }

        /// <summary>
        /// This method accepts <c> ProductImageDTO </c> entity and mapping to <c> ProductImageModel </c> then pushed to ProductImage repository for update to database
        /// </summary>
        /// <param name="entity"> ProductImageDTO ProductImage </param>
        /// <returns> Task </returns>
        public async Task UpdateAsync(ProductImageDTO entity)
        {
            var productImage = MapToModel(entity);
            if (productImage == null)
            {
                _logger.LogError("ProductImage model is null");
                throw new ArgumentNullException("ProductImage model is null");
            }
            await _productImageRepository.UpdateAsync(productImage);
        }

        /// <summary>
        /// This method accepts <c> ProductImageDTO </c> entity and mapping to <c> ProductImageModel </c> then pushed to ProductImage repository for remove entity to database
        /// </summary>
        /// <param name="entity"> ProductImageDTO ProductImage </param>
        /// <returns> Task </returns>
        public async Task RemoveAsync(ProductImageDTO entity)
        {
            var productImage = MapToModel(entity);
            if (productImage == null)
            {
                _logger.LogError("ProductImage model is null");
                throw new ArgumentNullException("ProductImage model is null");
            }
            await _productImageRepository.RemoveAsync(productImage);
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