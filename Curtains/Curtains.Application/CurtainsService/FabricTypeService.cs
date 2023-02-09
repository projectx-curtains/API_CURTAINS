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
    /// Class <c> FabricTypeService </c> a default implementetion of <c> IFabricTypeService </c>
    /// </summary>
    public class FabricTypeService : IFabricTypeService
    {
        private readonly IFabricTypeRepository _fabricTypeRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FabricTypeService(IFabricTypeRepository fabricTypeRepository, IMapper mapper, ILogger logger)
        {
            _fabricTypeRepository = fabricTypeRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<FabricTypeDTO> GetAll()
        {
            var fabricTypes = _mapper.Map<IEnumerable<FabricTypeDTO>>(_fabricTypeRepository.GetAll());
            return fabricTypes;
        }

        public async Task<FabricTypeDTO> GetByIdAsync(int Id)
        {
            var fabricType = await _fabricTypeRepository.GetByIdAsync(Id);
            if (fabricType == null)
            {
                _logger.LogError("Fabric type model is null");
                throw new ResourceNotFoundException("Fabric type model is null");
            }
            var fabricTypeDTO = _mapper.Map<FabricTypeDTO>(fabricType);
            return fabricTypeDTO;
        }

        public async Task InsertAsync(FabricTypeDTO entity, CancellationToken cancelationToken)
        {
            var fabricType = _mapper.Map<FabricTypeModel>(entity);
            if (fabricType == null)
            {
                _logger.LogError("Fabric type model is null");
                throw new ResourceNotFoundException("Fabric type model is null");
            }
            await _fabricTypeRepository.InsertAsync(fabricType, cancelationToken);
        }

        public async Task RemoveAsync(FabricTypeDTO entity)
        {
            var fabricType = _mapper.Map<FabricTypeModel>(entity);
            if (fabricType == null)
            {
                _logger.LogError("Fabric type model is null");
                throw new ResourceNotFoundException("Fabric type model is null");
            }
            await _fabricTypeRepository.RemoveAsync(fabricType);
        }

        public async Task UpdateAsync(FabricTypeDTO entity)
        {
            var fabricType = _mapper.Map<FabricTypeModel>(entity);
            if (fabricType == null)
            {
                _logger.LogError("Fabric type model is null");
                throw new ResourceNotFoundException("Fabric type model is null");
            }
            await _fabricTypeRepository.UpdateAsync(fabricType);
        }
    }
}
