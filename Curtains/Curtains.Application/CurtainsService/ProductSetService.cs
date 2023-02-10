using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Infrastructure.Shared.Exceptions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> ProductSetService </c> a default implementetion of <c> IProductSetService </c>
    /// </summary>
    public class ProductSetService : IProductSetService
    {
        private readonly IProductSetRepository _productSetRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ProductSetService(IProductSetRepository productSetRepository, IMapper mapper, ILogger logger)
        {
            _productSetRepository = productSetRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<ProductSetDTO> GetAll()
        {
            var sets = _mapper.Map<IEnumerable<ProductSetDTO>>(_productSetRepository.GetAll());
            return sets;
        }

        public async Task<ProductSetDTO> GetByIdAsync(int Id)
        {
            var productSet = await _productSetRepository.GetByIdAsync(Id);
            if (productSet == null)
            {
                _logger.LogError("Product set model is null");
                throw new ResourceNotFoundException("Product se is null");
            }
            var productSetDTO = _mapper.Map<ProductSetDTO>(productSet);
            return productSetDTO;
        }

        public async Task InsertAsync(ProductSetDTO entity, CancellationToken cancelationToken)
        {
            var productSet = _mapper.Map<ProductSetModel>(entity);
            if (productSet == null)
            {
                _logger.LogError("Product set model is null");
                throw new ResourceNotFoundException("Product se is null");
            }
            await _productSetRepository.InsertAsync(productSet, cancelationToken);
        }

        public async Task RemoveAsync(ProductSetDTO entity)
        {
            var productSet = _mapper.Map<ProductSetModel>(entity);
            if (productSet == null)
            {
                _logger.LogError("Product set model is null");
                throw new ResourceNotFoundException("Product se is null");
            }
            await _productSetRepository.RemoveAsync(productSet);
        }

        public async Task UpdateAsync(ProductSetDTO entity)
        {
            var productSet = _mapper.Map<ProductSetModel>(entity);
            if (productSet == null)
            {
                _logger.LogError("Product set model is null");
                throw new ResourceNotFoundException("Product se is null");
            }
            await _productSetRepository.UpdateAsync(productSet);
        }
    }
}
