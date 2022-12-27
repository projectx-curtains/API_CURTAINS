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

            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Take(model.Take)
                .Skip(model.Skip)
                .Query(q => q
                        .QueryString(qs => qs
                        .Fields(searchFields.Select(x => new Field(x)).ToArray()) /*.Query("Для кухни")*/
                        )
                    )
                
            /*.Highlight(h => h
                .Fields(searchFields
                    .Select<string, Func<HighlightFieldDescriptor<CurtainsProjection>, IHighlightField>>(s =>
                        hf => hf
                            .Field(s)).ToArray())));*/
            );
            if (!response.IsValid)
            {
                throw new Exception(response.DebugInformation);
            }

            var project = response.Documents.ToList();

            // var project = response.HitsMetadata.Hits.Select(h => h.Source).ToList();
            
            /*var list = response.Hits.Select(x => new CurtainsProjection()
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

            return project;
        }
    }
}