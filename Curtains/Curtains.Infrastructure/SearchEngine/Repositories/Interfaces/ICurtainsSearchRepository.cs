using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsSearchRepository
    {
        public Task<List<CurtainsProjection>> GetCurtains(ElasticSearchQuery<CurtainsProjection> model);
        public Task<List<CurtainsProjection>> GetTestCurtains(string purpose);
    }
}
