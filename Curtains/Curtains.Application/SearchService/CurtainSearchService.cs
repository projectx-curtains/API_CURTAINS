﻿using AutoMapper;
using Curtains.Application.SearchService.Interfaces;
using Curtains.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Curtains.Domain.Projections;
using Curtains.Application.DTO;
using Curtains.Infrastructure.SearchQueries;
using MediatR;
using Curtains.Domain.Models;

namespace Curtains.Application.SearchService
{
    public class CurtainSearchService : ICurtainSearchService
    {
        #region FieldsRegion       
        private readonly ICurtainsRepository _curtainsRepository;
        private readonly IElasticCurtainsIndexRepository _elasticIndexRepository;
        private readonly ICurtainsSearchRepository _curtainsSearchRepository;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        #endregion

        public CurtainSearchService(ILogger logger,
            ICurtainsRepository curtainsRepository,
            IMapper mapper,
            IElasticCurtainsIndexRepository elasticIndexRepository,
            ICurtainsSearchRepository curtainsSearchRepository,
            IMediator mediator)
        {
            _curtainsRepository = curtainsRepository;
            _elasticIndexRepository = elasticIndexRepository;
            _mapper = mapper;
            _curtainsSearchRepository = curtainsSearchRepository;
            _mediator = mediator;
        }

        #region MethodsRegion
        public async Task AddAllCurtains(string indexName)
        {
            var ListModelsDTO = _mapper.Map<IEnumerable<CurtainsDTO>>(_curtainsRepository.GetAll());

            foreach (var modelDTO in ListModelsDTO)
            {
                var projectionModel = _mapper.Map<CurtainsProjection>(modelDTO);
                await _elasticIndexRepository.Index(projectionModel, indexName);
            }
        }

        public IEnumerable<CurtainsModel> GetAllCurtains() 
        {
            return _curtainsRepository.GetAll();
        }

        public async Task<List<CurtainsProjection>> CurtainsSearch(ElasticSearchQuery<CurtainSearchDTO> model)
        {
            var modelProjection = _mapper.Map<ElasticSearchQuery<CurtainsProjection>>(model);
            var response = await _curtainsSearchRepository.GetCurtains(modelProjection);
            return response;
        }
        #endregion

        public async Task<List<CurtainsProjection>> GetTestService(string purpose)
        {
            return await _curtainsSearchRepository.GetTestCurtains(purpose);
        }
    }
}
