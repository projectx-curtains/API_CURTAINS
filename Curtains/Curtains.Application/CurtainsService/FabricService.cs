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
    /// Class <c> FabricService </c> a default implementetion of <c> IFabricService </c>
    /// </summary>
    public class FabricService : IFabricService
    {
        private readonly IFabricRepository _fabricRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FabricService(IFabricRepository fabricRepository, IMapper mapper, ILogger logger)
        {
            _fabricRepository = fabricRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<FabricDTO> GetAll()
        {
            var fabrics = _mapper.Map<IEnumerable<FabricDTO>>(_fabricRepository.GetAll());
            return fabrics;
        }

        public async Task<FabricDTO> GetByIdAsync(int Id)
        {
            var fabric = await _fabricRepository.GetByIdAsync(Id);
            if (fabric == null)
            {
                _logger.LogError("Fabric model is null");
                throw new ResourceNotFoundException("Fabric model is null");
            }
            var fabricDTO = _mapper.Map<FabricDTO>(fabric);
            return fabricDTO;
        }

        public async Task InsertAsync(FabricDTO entity, CancellationToken cancelationToken)
        {
            var fabric = _mapper.Map<FabricModel>(entity);
            if (fabric == null)
            {
                _logger.LogError("Fabric model is null");
                throw new ResourceNotFoundException("Fabric model is null");
            }
            await _fabricRepository.InsertAsync(fabric, cancelationToken);
        }

        public async Task RemoveAsync(FabricDTO entity)
        {
            var fabric = _mapper.Map<FabricModel>(entity);
            if (fabric == null)
            {
                _logger.LogError("Fabric model is null");
                throw new ResourceNotFoundException("Fabric model is null");
            }
            await _fabricRepository.RemoveAsync(fabric);
        }

        public async Task UpdateAsync(FabricDTO entity)
        {
            var fabric = _mapper.Map<FabricModel>(entity);
            if (fabric == null)
            {
                _logger.LogError("Fabric model is null");
                throw new ResourceNotFoundException("Fabric model is null");
            }
            await _fabricRepository.UpdateAsync(fabric);
        }
    }
}
