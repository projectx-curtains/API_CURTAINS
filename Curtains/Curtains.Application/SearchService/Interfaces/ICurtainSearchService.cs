using Curtains.Application.DTO;

namespace Curtains.Application.SearchService.Interfaces
{
    public interface ICurtainSearchService
    {
        public Task AddAllCurtains(string indexName);
    }
}
