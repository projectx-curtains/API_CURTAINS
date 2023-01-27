using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Application.SearchService.Interfaces
{
    public interface ICurtainSearchService
    {
        public Task AddAllCurtains();
        public Task<List<SearchResults<CurtainsProjection>>> CurtainsSearch(ElasticSearchQuery<CurtainSearchDTO> model);

        public IEnumerable<CurtainsModel> GetAllCurtains();
    }
}
