using Nest;
using Elasticsearch.Net;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Domain.Projections;

namespace Curtains.Infrastructure.SearchEngine
{
    public class ElasticCurtainsIndexRepository : IElasticCurtainsIndexRepository
    {
        private readonly IElasticClient _elasticClient;

        public ElasticCurtainsIndexRepository(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<bool> Index(CurtainsProjection model, string indexName)
        {
            var response = await _elasticClient.IndexAsync(model, i => i
                .Index(indexName)
                .Id(model.Id)
                .Refresh(Refresh.True)
            );

            if (!response.IsValid)
            {             
                throw new Exception(response.DebugInformation);
            }
            else
                return true;
        }

        public async Task<bool> Deleted(string id, string indexName)
        {
            var response = await _elasticClient.DeleteAsync(new DeleteRequest(indexName, id.Trim()));

            if (!response.IsValid)
            {
                throw new Exception(response.DebugInformation);
            }
            else
                return true;
        }
    }
}
