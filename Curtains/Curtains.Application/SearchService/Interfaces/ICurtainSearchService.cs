using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Application.SearchService.Interfaces
{
    public interface ICurtainSearchService
    {
        public Task AddAllCurtains(string indexName);
        public Task<List<CurtainsProjection>> CurtainsSearch(ElasticSearchQuery<CurtainSearchDTO> model);

        public IEnumerable<CurtainsModel> GetAllCurtains();
        public Task<List<CurtainsProjection>> GetTestService(string purpose);
    }
}
