using Curtains.Infrastructure.Interfaces;
using Nest;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;
using Elasticsearch.Net;

namespace Curtains.Infrastructure.SearchEngine
{
    public class CurtainsSearchRepository : ICurtainsSearchRepository
    {

        private readonly IElasticClient _elasticClient;
       // private readonly ElasticSearchOptions _options;

        public CurtainsSearchRepository(IElasticClient elasticsearchClient)
        {
            _elasticClient = elasticsearchClient;
        }

        public async Task<List<SearchResults<CurtainsProjection>>> GetCurtains(ElasticSearchQuery<CurtainsProjection> model)
        {

            var searchFields = SearchRules.CurtainsSearchFields;

            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Query(q => q
                    .Bool(b => b
                        .Must(mu => mu
							.QueryString(qs => qs
							.Query(model.Search)
							.Fields(searchFields.Select(x => new Field(x)).ToArray())))
						.Must(mu => mu
                            .Terms(t => t.Field(f => f.Color).Terms(model.Filters.Colors)))))
                .Highlight(h => h
					.Fields(searchFields.Select<string, Func<HighlightFieldDescriptor<CurtainsProjection>, IHighlightField>>(s =>
							hf => hf
								.Field(s)).ToArray())));


			

			if (!response.IsValid)
			{
				throw new Exception(response.DebugInformation);
			}

			var list = response.Hits.Select(x => new SearchResults<CurtainsProjection>()
			{
				Result = x.Source,
				Highlight = x.Highlight

			}).ToList();

			return list;
		}

		public async Task<bool> Index(CurtainsProjection model)
		{
			var response = await _elasticClient.IndexAsync(model, i => i
				.Index("_Option.DefaultIndex")
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

		public async Task<bool> Deleted(string id)
		{
			var response = await _elasticClient.DeleteAsync(new DeleteRequest("_Option.DefaultIndex",id.Trim()));

			if (!response.IsValid)
			{
				throw new Exception(response.DebugInformation);
			}
			else
				return true;
		}
	}

    /*.Query(q => q
                    .Bool(bq => bq
                        .Filter(fq =>
                        {
        QueryContainer query = null;

        if (model.Filters.Colors != null)
        {
            query &= fq.Terms(t => t.Field(f => f.Color).Terms(model.Filters.Colors));
        }

        if (model.Filters.CurtainsTypes != null)
        {
            query &= fq.Terms(t => t.Field(f => f.CurtainsType).Terms(model.Filters.CurtainsTypes));
        }

        if (model.Filters.CurtainsKind != null)
        {
            query &= fq.Terms(t => t.Field(f => f.CurtainsKind).Terms(model.Filters.CurtainsKind));
        }

        if (model.Filters.Materials != null)
        {
            query &= fq.Terms(t => t.Field(f => f.Material).Terms(model.Filters.Materials));
        }

        if (model.Filters.Fabric != null)
        {
            query &= fq.Terms(t => t.Field(f => f.Fabric).Terms(model.Filters.Fabric));
        }

        if (model.Filters.Purpose != null)
        {
            query &= fq.Terms(t => t.Field(f => f.Purpose).Terms(model.Filters.Purpose));
        }

        return query;
    })
                    )
                )*/
    
}

/*var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
				.Take(model.Take)
				.Skip(model.Skip)
				.Query(q => q
						.QueryString(qs => qs
							.Query(model.Search)
							.Fields(searchFields.Select(x => new Field(x)).ToArray())
						)
					)
				.Highlight(h => h
					.Fields(searchFields.Select<string, Func<HighlightFieldDescriptor<CurtainsProjection>, IHighlightField>>(s =>
							hf => hf
								.Field(s)).ToArray()))
				);*/

/*var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Query(q => q
                    .Bool(b => b
                        .Must(mu => mu
                            .MultiMatch(mm => mm
                                .Query(model.Search)
                                .Fields(searchFields)
                                .Type(TextQueryType.MostFields)
                                .PrefixLength(2)
                                .Boost(5)
                            )
                        )
                        .Must(
                            sh => sh.Terms(t => t
                                .Field(f => f.Purpose)
                                .Terms(model.Filters.Purpose)
                            ),
                            sh => sh.Terms(t => t
                                .Field(f => f.Color)
                                .Terms(model.Filters.Colors)
                            )
                        )
                    )
                )
            );*/

