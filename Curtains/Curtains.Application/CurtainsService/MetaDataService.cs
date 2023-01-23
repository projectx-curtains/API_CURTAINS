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
    /// Class <c> MetaDataService </c> a default implementetion of <c> IMetaDataService </c>
    /// </summary>
    public class MetaDataService : IMetaDataService
    {
        private readonly IMetaDataRepository _metaDataRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public MetaDataService(IMetaDataRepository metaDataRepository, IMapper mapper, ILogger logger)
        {
            _metaDataRepository = metaDataRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<MetaDataDTO> GetAll()
        {
            var metaData = _mapper.Map<IEnumerable<MetaDataDTO>>(_metaDataRepository.GetAll());
            return metaData;
        }

        public async Task<MetaDataDTO> GetByIdAsync(int Id)
        {
            var metaData = await _metaDataRepository.GetByIdAsync(Id);
            if (metaData == null)
            {
                _logger.LogError("Meta data model is null");
                throw new ResourceNotFoundException("Meta data model is null");
            }
            var metaDataDTO = _mapper.Map<MetaDataDTO>(metaData);
            return metaDataDTO;
        }

        public async Task InsertAsync(MetaDataDTO entity, CancellationToken cancelationToken)
        {
            var metaData = _mapper.Map<MetaDataModel>(entity);
            if (metaData == null)
            {
                _logger.LogError("Meta data model is null");
                throw new ResourceNotFoundException("Meta data model is null");
            }
            await _metaDataRepository.InsertAsync(metaData, cancelationToken);
        }

        public async Task RemoveAsync(MetaDataDTO entity)
        {
            var metaData = _mapper.Map<MetaDataModel>(entity);
            if (metaData == null)
            {
                _logger.LogError("Meta data model is null");
                throw new ResourceNotFoundException("Meta data model is null");
            }
            await _metaDataRepository.RemoveAsync(metaData);
        }

        public async Task UpdateAsync(MetaDataDTO entity)
        {
            var metaData = _mapper.Map<MetaDataModel>(entity);
            if (metaData == null)
            {
                _logger.LogError("Meta data model is null");
                throw new ResourceNotFoundException("Meta data model is null");
            }
            await _metaDataRepository.UpdateAsync(metaData);
        }
    }
}
