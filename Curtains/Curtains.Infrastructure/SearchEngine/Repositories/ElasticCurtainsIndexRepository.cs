using Nest;
using Elasticsearch.Net;
using Curtains.Domain.Models;

namespace Curtains.Infrastructure.Repositories
{
    public class ElasticCurtainsIndexRepository //: IElasticCurtainsIndexRepository
    {
        private readonly ElasticClient _elasticClient;

        public ElasticCurtainsIndexRepository(ElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public bool Index(CurtainsModel model, string indexName)
        {
            var response = _elasticClient.Index(model, i => i
                .Index(indexName)
                .Id(model.Id)
                .Refresh(Refresh.True)
            );

            return true;
        }

        public bool Delete(CurtainsModel model, string indexName)
        {
            var response = _elasticClient.Delete<CurtainsModel>(model.Id, d => d
            .Index(indexName));

            return true;
        }
    }
}
