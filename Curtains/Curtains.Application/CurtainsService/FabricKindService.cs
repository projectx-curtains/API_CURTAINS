using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Infrastructure.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> FabricKindService </c> a default implementetion of <c> IFabricKindService </c>
    /// </summary>
    public class FabricKindService : IFabricKindService
    {
        private readonly IFabricKindRepository _fabricKindRepository;
        private readonly IMapper _mapper;

        public FabricKindService(IFabricKindRepository fabricKindRepository, IMapper mapper)
        {
            _fabricKindRepository = fabricKindRepository;
            _mapper = mapper;
        }

        public IEnumerable<FabricKindDTO> GetAll()
        {
            var fabricKinds = _mapper.Map<IEnumerable<FabricKindDTO>>(_fabricKindRepository.GetAll());
            return fabricKinds;
        }

        public async Task<FabricKindDTO> GetByIdAsync(int Id)
        {
            var fabricKind = await _fabricKindRepository.GetByIdAsync(Id);
            if (fabricKind == null)
            {
                _logger.LogError("Fabric kind model is null");
                throw new ResourceNotFoundException("Fabric kind model is null");
            }
            var fabricKindDTO = _mapper.Map<FabricKindDTO>(fabricKind);
            return fabricKindDTO;
        }

        public async Task InsertAsync(FabricKindDTO entity, CancellationToken cancelationToken)
        {
            var fabricKind = _mapper.Map<FabricKindModel>(entity);
            if (fabricKind == null)
            {
                _logger.LogError("Fabric kind model is null");
                throw new ResourceNotFoundException("Fabric kind model is null");
            }
            await _fabricKindRepository.InsertAsync(fabricKind, cancelationToken);
        }

        public async Task RemoveAsync(FabricKindDTO entity)
        {
            var fabricKind = _mapper.Map<FabricKindModel>(entity);
            if (fabricKind == null)
            {
                _logger.LogError("Fabric kind model is null");
                throw new ResourceNotFoundException("Fabric kind model is null");
            }
            await _fabricKindRepository.RemoveAsync(fabricKind);
        }

        public async Task UpdateAsync(FabricKindDTO entity)
        {
            var fabricKind = _mapper.Map<FabricKindModel>(entity);
            if (fabricKind == null)
            {
                _logger.LogError("Fabric kind model is null");
                throw new ResourceNotFoundException("Fabric kind model is null");
            }
            await _fabricKindRepository.UpdateAsync(fabricKind);
        }
    }
}
