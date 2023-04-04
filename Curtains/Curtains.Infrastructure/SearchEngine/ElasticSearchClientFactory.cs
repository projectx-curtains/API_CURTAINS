using Curtains.Domain.Projections;
using Elasticsearch.Net;
using Nest;
using Nest.JsonNetSerializer;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Curtains.Infrastructure.SearchEngine
{
    public static class ElasticSearchClientFactory
    {
        public static IElasticClient Create(ElasticSearchOptions options)
        {
            var pool = new SingleNodeConnectionPool(new Uri(options.Url));
            var connectionSettings = new ConnectionSettings(pool,
                    (builtin, settings) => new JsonNetSerializer(builtin, settings,
                        contractJsonConverters: new JsonConverter[]
                        {
                            new StringEnumConverter(new CamelCaseNamingStrategy())
                        }))
                .BasicAuthentication(options.Login, options.Password)
                .DefaultIndex(options.DefaultIndex)
                .DefaultMappingFor<CurtainsProjection>(m => m.IdProperty(x => x.Id));

            return new ElasticClient(connectionSettings);
        }
    }
}