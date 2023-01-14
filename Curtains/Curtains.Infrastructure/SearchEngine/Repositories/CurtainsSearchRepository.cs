using Curtains.Infrastructure.Interfaces;
using Nest;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Infrastructure.SearchEngine
{
    public class CurtainsSearchRepository : ICurtainsSearchRepository
    {

        private readonly IElasticClient _elasticClient;

        public CurtainsSearchRepository(IElasticClient elasticsearchClient)
        {
            _elasticClient = elasticsearchClient;
        }

        public async Task<List<CurtainsProjection>> GetCurtains(ElasticSearchQuery<CurtainsProjection> model)
        {

            string[] searchFields = SearchRules.CurtainsSearchFields;

            /*var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Take(model.Take)
                .Skip(model.Skip)
                .Query(q => q
                        .QueryString(qs => qs
                        .Fields(searchFields.Select(x => new Field(x)).ToArray()).Query(model.Filters.ToString())
                        )
                    )
                );*/
            /*.Highlight(h => h
                .Fields(searchFields
                    .Select<string, Func<HighlightFieldDescriptor<CurtainsProjection>, IHighlightField>>(s =>
                        hf => hf
                            .Field(s)).ToArray())));*/

            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Query(q => q
                    .Bool(bq => bq
                        .Filter(fq =>
                        {
                            QueryContainer query = null;

                            if (model.Filters.Colors.Any())
                                query &= fq.Terms(t => t.Field(f => f.Color).Terms(model.Filters.Colors));

                            if (model.Filters.Purpose.Any())
                                query &= fq.Terms(t => t.Field(f => f.Purpose).Terms(model.Filters.Purpose));

                            return query;
                        })
                    )
                )
            );


            if (!response.IsValid)
            {
                throw new Exception(response.DebugInformation);
            }

            
            var list = response.Documents.ToList();

            // var project = response.HitsMetadata.Hits.Select(h => h.Source).ToList();

            return list;
        }

        public async Task<List<CurtainsProjection>> GetTestCurtains(string purpose)
        {
            var search = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Query(q => q
                    .Bool(bq => bq
                        .Filter(fq =>
                        {
                            QueryContainer query = null;

                            if (purpose.Any())
                                query &= fq.Terms(t => t.Field(f => f.Price).Terms(purpose));

                            return query;
                        })
                    )
                )
            );

            // string[] searchFields = SearchRules.CurtainsSearchFields;

            /*var search = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Query(q => q
                    .Bool(b => b
                        .Must(mu => mu
                            .MultiMatch(mm => mm
                                .Query(purpose)
                                .Fields(searchFields)
                            )
                        )
                        .Filter(fq =>
                        {
                            QueryContainer query = null;

                            if (purpose.Any())
                                query &= fq.Terms(t => t.Field(f => f.Purpose).Terms(purpose));

                            return query;
                        })
                    )
                )
            );*/

            if (!search.IsValid)
            {
                throw new Exception(search.DebugInformation);
            }

            /*var list = search.Hits.Select(x => new CurtainsProjection()
            {
                Id = x.Source.Id,
                Title = x.Source.Title,
                Description = x.Source.Description,
                Purpose = x.Source.Purpose,
                Price = x.Source.Price,
                Density = x.Source.Density,
                SunProtection = x.Source.SunProtection,
                Height = x.Source.Height,
                Width = x.Source.Width,
                Fabric = x.Source.Fabric,
                Color = x.Source.Color,
                Material = x.Source.Material,
                CurtainsType = x.Source.CurtainsType,
                CurtainsKind = x.Source.CurtainsKind
            }).ToList();*/

            var list = search.Documents.ToList();

            return list;
        }
    }

    
}