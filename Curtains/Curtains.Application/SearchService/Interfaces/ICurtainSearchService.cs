using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Application.SearchService.Interfaces
{
    public interface ICurtainSearchService
    {
        public Task IndexesCurtains();
        public Task<List<SearchResults<CurtainsProjection>>> CurtainsSearch(ElasticSearchQuery<CurtainSearchDTO> model);
        public Task DeleteCurtain(string id);

	}
}
