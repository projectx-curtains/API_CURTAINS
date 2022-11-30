using Curtains.Infrastructure.Interfaces;
using Nest;
using Nest.JsonNetSerializer;
using Curtains.Domain.Projections;
using System;

namespace Curtains.Infrastructure.SearchEngine
{

    public class CurtainsSearchRepository : ICurtainsSearchRepository
    {

        private readonly IElasticClient _elasticClient;

        public CurtainsSearchRepository(IElasticClient elasticsearchClient)
        {
            _elasticClient = elasticsearchClient;
        }

        public async Task<List<CurtainsProjection>> GetCurtains(CurtainsProjection model, string indexName)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Index(indexName)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.Id.ToString())
                            .Query(model.Id.ToString())
                        )
                    )
                );

            var list = response.Hits.Select( x => new CurtainsProjection()
            {
                Width = x.Source.Width
            }).ToList();
            return list;
        }

        private CurtainsProjection ConvertHitToModel(IHit<CurtainsProjection> hit)

        {
            return new CurtainsProjection();            
        }
            
        /*public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByFabric(string indexName, string fabricId)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
               .Index(indexName)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.FabricId.ToString())
                            .Query(fabricId)
                        )
                    )
                );

            return response;
        }

        public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByColor(string indexName, string colorId)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Index(indexName)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.ColorId.ToString())
                            .Query(colorId)
                        )
                    )
                );

            return response;
        }

        public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByMaterial(string indexName, string materialId)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Index(indexName)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.MaterialId.ToString())
                            .Query(materialId)
                        )
                    )
                );

            return response;
        }

        public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByCurtainsType(string indexName, string curtainsTypeId)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Index(indexName)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.CurtainsTypeId.ToString())
                            .Query(curtainsTypeId)
                        )
                    )
                );
            return response;
        }

        public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByCurtainsKind(string indexName, string curtainsKindId)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Index(indexName)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.CurtainsKindId.ToString())
                            .Query(curtainsKindId)
                        )
                    )
                );
            return response;
        }

        public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByPurpose(string indexName, string purpose)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Index(indexName)
                    .Query(q => q
                        .Term(t => t
                            .Field(f => f.Purpose)
                            .Value(purpose)
                        )
                    )
                );
            return response;
        }

        public async Task<ISearchResponse<CurtainsProjection>> GetProductByPriceRange(string indexName, int priceLowerLimit, int priceHigherLimit)
        {
            var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
                .Index(indexName)
                    .Query(q => q
                        .Range(m => m
                            .Field(f => f.Price)
                            .GreaterThanOrEquals(priceLowerLimit)
                            .LessThan(priceHigherLimit)
                        )
                    )
                );
            return response;
        }*/
    }
}