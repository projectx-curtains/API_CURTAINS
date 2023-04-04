using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsSearchRepository
    {
        public Task<List<SearchResults<CurtainsProjection>>> GetCurtains(ElasticSearchQuery<CurtainsProjection> model);
		public Task<bool> Index(CurtainsProjection model);
		public Task<bool> Delete(string id);
	}
}
