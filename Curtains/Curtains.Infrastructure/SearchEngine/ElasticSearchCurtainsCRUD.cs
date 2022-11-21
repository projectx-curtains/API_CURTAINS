using Nest;
using Elasticsearch.Net;
using Curtains.Domain.Models;

namespace Curtains.Infrastructure.SearchEngine
{
    public class ElasticSearchCurtainsCRUD
    {
        private readonly ElasticClient _elasticClient;

        public ElasticSearchCurtainsCRUD(ElasticClient elasticClient)
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
