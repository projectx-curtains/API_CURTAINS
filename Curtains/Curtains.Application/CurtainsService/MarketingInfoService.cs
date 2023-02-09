using Curtains.Application.DTO;
using Curtains.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Curtains.Infrastructure.Shared.Exceptions;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Repositories;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> MarketingInfoService </c> describes the interaction model of the data transfer object to the database.
    /// </summary>
    public class MarketingInfoService : IMarketingInfoService
    {
        #region FieldsRegion
        private readonly IMarketingInfoRepository _marketingInfoRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        #endregion

        public MarketingInfoService(IMarketingInfoRepository marketingInfoRepository,
                                    IMapper mapper,
                                    ILogger logger)
        {
            _marketingInfoRepository = marketingInfoRepository;
            _mapper = mapper;
            _logger = logger;
        }

        #region MethodsRegion

        /// <summary>
        /// This method return all<c> marketing info <c> entities from database
        /// </summary>
        /// <returns>Collection of Marketing infos</returns>
        public IEnumerable<MarketingInfoDTO> GetAll()
        {
            var marketingInfos = _mapper.Map<IEnumerable<MarketingInfoDTO>>(_marketingInfoRepository.GetAll());
            return marketingInfos;
        }

         /// <summary>
        /// This method return <c> MarketingInfo <c> entitie by id from database
        /// </summary>
        /// <returns>Marketing info</returns>
        public async Task<MarketingInfoDTO> GetByIdAsync(int Id)
        {
            var marketingInfo = await _marketingInfoRepository.GetByIdAsync(Id);
            if (marketingInfo == null)
            {
                _logger.LogError("Marketing info model is null");
                throw new ResourceNotFoundException("Marketing info model is null");
            }
            var marketingInfoDTO = _mapper.Map<MarketingInfoDTO>(marketingInfo);
            return marketingInfoDTO;
        }

        public async Task InsertAsync(MarketingInfoDTO entity, CancellationToken cancelationToken)
        {
            var marketingInfo = _mapper.Map<MarketingInfoModel>(entity);
            if (marketingInfo == null)
            {
                _logger.LogError("Marketing info model is null");
                throw new ResourceNotFoundException("Marketing info model is null");
            }
            await _marketingInfoRepository.InsertAsync(marketingInfo, cancelationToken);
        }

        public async Task RemoveAsync(MarketingInfoDTO entity)
        {
            var marketingInfo = _mapper.Map<MarketingInfoModel>(entity);
            if (marketingInfo == null)
            {
                _logger.LogError("Marketing info model is null");
                throw new ResourceNotFoundException("Marketing info model is null");
            }
            await _marketingInfoRepository.RemoveAsync(marketingInfo);
        }

        public async Task UpdateAsync(MarketingInfoDTO entity)
        {
            var marketingInfo = _mapper.Map<MarketingInfoModel>(entity);
            if (marketingInfo == null)
            {
                _logger.LogError("Marketing info model is null");
                throw new ResourceNotFoundException("Marketing info model is null");
            }
            await _marketingInfoRepository.UpdateAsync(marketingInfo);
        }
        #endregion
    }
}
