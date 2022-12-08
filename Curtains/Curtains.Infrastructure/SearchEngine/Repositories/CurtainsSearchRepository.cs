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
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                    .Query(q => q
                        .Terms(t => t
                            .Field(f => f.Color)
                            .Terms(model.Filters.Colors)

                            .Field(f => f.Material)
                            .Terms(model.Filters.Materials)

                            .Field(f => f.CurtainsType)
                            .Terms(model.Filters.CurtainsTypes)
                        )
                    )
                    .Take(model.Take)
                    .Skip(model.Skip)
                );

            if (!response.IsValid)
            {
                throw new Exception(response.DebugInformation);
            }
            var list = response.Hits.Select(x => new CurtainsProjection()
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
            }).ToList();

            return list;
        }
    }
}