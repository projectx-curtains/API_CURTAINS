using Curtains.Domain.Projections;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IElasticCurtainsIndexRepository
    {
        public Task<bool> Index(CurtainsProjection model, string indexName);
        public Task<bool> Deleted(string id, string indexName);
    }
}

