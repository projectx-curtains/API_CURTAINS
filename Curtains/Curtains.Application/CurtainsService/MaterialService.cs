using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Infrastructure.Shared.Exceptions;
using Microsoft.Extensions.Logging;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> MaterialService </c> a default implementetion of <c> IMaterialService </c>
    /// </summary>
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public MaterialService(IMaterialRepository materialRepository, IMapper mapper, ILogger logger)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<MaterialDTO> GetAll()
        {
            var materials = _mapper.Map<IEnumerable<MaterialDTO>>(_materialRepository.GetAll());
            return materials;
        }

        public async Task<MaterialDTO> GetByIdAsync(int Id)
        {
            var material = await _materialRepository.GetByIdAsync(Id);
            if (material == null)
            {
                _logger.LogError("Material model is null");
                throw new ResourceNotFoundException("Material model is null");
            }
            var materialDTO = _mapper.Map<MaterialDTO>(material);
            return materialDTO;
        }

        public async Task InsertAsync(MaterialDTO entity, CancellationToken cancelationToken)
        {
            var material = _mapper.Map<MaterialModel>(entity);
            if (material == null)
            {
                _logger.LogError("Material model is null");
                throw new ResourceNotFoundException("Material model is null");
            }
            await _materialRepository.InsertAsync(material, cancelationToken);
        }

        public async Task RemoveAsync(MaterialDTO entity)
        {
            var material = _mapper.Map<MaterialModel>(entity);
            if (material == null)
            {
                _logger.LogError("Material model is null");
                throw new ResourceNotFoundException("Material model is null");
            }
            await _materialRepository.RemoveAsync(material);
        }

        public async Task UpdateAsync(MaterialDTO entity)
        {
            var material = _mapper.Map<MaterialModel>(entity);
            if (material == null)
            {
                _logger.LogError("Material model is null");
                throw new ResourceNotFoundException("Material model is null");
            }
            await _materialRepository.UpdateAsync(material);
        }
    }
}
