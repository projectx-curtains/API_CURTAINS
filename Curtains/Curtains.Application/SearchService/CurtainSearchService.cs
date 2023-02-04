using AutoMapper;
using Curtains.Application.SearchService.Interfaces;
using Curtains.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Curtains.Domain.Projections;
using Curtains.Application.DTO;
using Curtains.Infrastructure.SearchQueries;
using Curtains.Domain.Models;

namespace Curtains.Application.SearchService
{
	/// <summary>
	/// Class <c> CurtainSearchService </c> describes the interaction model 
    /// of the data transfer object to the database and ElasticSearch
	/// </summary>
	public class CurtainSearchService : ICurtainSearchService
    {
        #region FieldsRegion       
        private readonly ICurtainsRepository _curtainsRepository;
        private readonly ICurtainsSearchRepository _curtainsSearchRepository;
        private readonly IMapper _mapper;
        #endregion

        public CurtainSearchService(ILogger logger,
            ICurtainsRepository curtainsRepository,
            IMapper mapper,
            ICurtainsSearchRepository curtainsSearchRepository)
        {
            _curtainsRepository = curtainsRepository;
            _mapper = mapper;
            _curtainsSearchRepository = curtainsSearchRepository;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get all <c> CurtainModels </c> entities from database
        /// and mapping to <c> CurtainsProjection </c> and indexes data into ElasticSearch
        /// </summary>
        /// <returns></returns>
        public async Task AddAllCurtains()
        {
            var ListModelsDTO = _mapper.Map<IEnumerable<CurtainsDTO>>(_curtainsRepository.GetAll());

            foreach (var modelDTO in ListModelsDTO)
            {
                var projectionModel = _mapper.Map<CurtainsProjection>(modelDTO);
                await _curtainsSearchRepository.Index(projectionModel);
            }
        }

        /// <summary>
        /// This method gel all <c> CurtainsModel </c> entities from database
        /// </summary>
        /// <returns> Collection of <c> CurtainsModel </c></returns>
        public IEnumerable<CurtainsModel> GetAllCurtains() 
        {
            return _curtainsRepository.GetAll();
        }

		/// <summary>
		/// This method mapping <c> ElasticSearchQuery<CurtainSearchDTO> </c> to <c> ElasticSearchQuery<CurtainProjection> </c>
        /// and get all <c> SearchResults<CurtainsProjection> </c> entities from ElasticSearch
		/// </summary>
		/// <param name="model"> Model of search query </param>
		/// <returns> List of <c> SearchResults<CurtainsProjection> </c> </returns>
		public async Task<List<SearchResults<CurtainsProjection>>> CurtainsSearch(ElasticSearchQuery<CurtainSearchDTO> model)
        {
            var modelProjection = _mapper.Map<ElasticSearchQuery<CurtainsProjection>>(model);
            var response = await _curtainsSearchRepository.GetCurtains(modelProjection);
            return response;
        }
        #endregion
    }
}
