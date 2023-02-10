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
    /// Class <c> AccessoriesService </c> a default implementetion of <c> IAccessoriesService </c>
    /// </summary>
    public class AccessoriesService : IAccessoriesService
    {
        private readonly IAccessoriesRepository _accessoriesRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public AccessoriesService(IAccessoriesRepository accessoriesRepository, IMapper mapper, ILogger logger)
        {
            _accessoriesRepository = accessoriesRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<AccessoriesDTO> GetAll()
        {
            var accessories = _mapper.Map<IEnumerable<AccessoriesDTO>>(_accessoriesRepository.GetAll());
            return accessories;
        }

        public async Task<AccessoriesDTO> GetByIdAsync(int Id)
        {
            var accessories = await _accessoriesRepository.GetByIdAsync(Id);
            if (accessories == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ResourceNotFoundException("Accessories model is null");
            }
            var accessoriesDTO = _mapper.Map<AccessoriesDTO>(accessories);
            return accessoriesDTO;
        }

        public async Task InsertAsync(AccessoriesDTO entity, CancellationToken cancelationToken)
        {
            var accessories = _mapper.Map<AccessoriesModel>(entity);
            if (accessories == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ResourceNotFoundException("Accessories model is null");
            }
            await _accessoriesRepository.InsertAsync(accessories, cancelationToken);
        }

        public async Task RemoveAsync(AccessoriesDTO entity)
        {
            var accessory = _mapper.Map<AccessoriesModel>(entity);
            if (accessory == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ResourceNotFoundException("Accessories model is null");
            }
            await _accessoriesRepository.RemoveAsync(accessory);
        }

        public async Task UpdateAsync(AccessoriesDTO entity)
        {
            var accessory = _mapper.Map<AccessoriesModel>(entity);
            if (accessory == null)
            {
                _logger.LogError("Accessories model is null");
                throw new ResourceNotFoundException("Accessories model is null");
            }
            await _accessoriesRepository.UpdateAsync(accessory);
        }
    }
}
