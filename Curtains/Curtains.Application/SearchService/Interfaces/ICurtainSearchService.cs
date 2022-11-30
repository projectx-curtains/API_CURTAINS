using Curtains.Application.DTO;
using Curtains.Domain.Projections;
using Nest;


namespace Curtains.Application.SearchService.Interfaces
{
    public interface ICurtainSearchService
    {
        public Task AddAllCurtains(string indexName);
        public Task<List<CurtainsProjection>> CurtainsSearch(CurtainsDTO modelDTO, string indexName);
    }
}
