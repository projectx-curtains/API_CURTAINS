using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
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

        public ProductSetService(IProductSetRepository productSetRepository, IMapper mapper)
        {
            _productSetRepository = productSetRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductSetDTO> GetAll()
        {
            var sets = _mapper.Map<IEnumerable<ProductSetDTO>>(_productSetRepository.GetAll());
            return sets;
        }

        public async Task<ProductSetDTO> GetByIdAsync(int Id)
        {
            var productSet = await _productSetRepository.GetByIdAsync(Id);
            var productSetDTO = _mapper.Map<ProductSetDTO>(productSet);
            return productSetDTO;
        }

        public async Task InsertAsync(ProductSetDTO entity, CancellationToken cancelationToken)
        {
            var productSet = _mapper.Map<ProductSetModel>(entity);
            await _productSetRepository.InsertAsync(productSet, cancelationToken);
        }

        public async Task RemoveAsync(ProductSetDTO entity)
        {
            var productSet = _mapper.Map<ProductSetModel>(entity);
            await _productSetRepository.RemoveAsync(productSet);
        }

        public async Task UpdateAsync(ProductSetDTO entity)
        {
            var productSet = _mapper.Map<ProductSetModel>(entity);
            await _productSetRepository.UpdateAsync(productSet);
        }
    }
}
