using AutoMapper;
using Curtains.Application.SearchService.Interfaces;
using Curtains.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Curtains.Domain.Projections;
using Curtains.Application.DTO;
using Curtains.Infrastructure.SearchEngine;
using Curtains.Domain.Models;

namespace Curtains.Application.SearchService
{
    public class CurtainSearchService : ICurtainSearchService
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly ICurtainsRepository _curtainsRepository;
        private readonly IElasticCurtainsIndexRepository _elasticRepository;
        private readonly IMapper _mapper;
        #endregion

        public CurtainSearchService(ILogger logger, ICurtainsRepository curtainsRepository,
            IMapper mapper, IElasticCurtainsIndexRepository elasticRepository)
        {
            _logger = logger;
            _curtainsRepository = curtainsRepository;
            _elasticRepository = elasticRepository;
            _mapper = mapper;
        }

        #region MethodsRegion
        public async Task AddAllCurtains(string indexName)
        {
            var ListModelsDTO = _mapper.Map<IEnumerable<CurtainsDTO>>(_curtainsRepository.GetAll());

            foreach (var modelDTO in ListModelsDTO)
            {
                var projectionModel = _mapper.Map<CurtainsProjection>(modelDTO);
                await _elasticRepository.Index(projectionModel, indexName);
            }
        }
        #endregion
    }
}
