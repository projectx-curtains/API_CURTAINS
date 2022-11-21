using Curtains.Domain.Search;
using Nest;
using Curtains.Domain.Projections;

namespace Curtains.Infrastructure.SearchEngine.Repositories;

public class CurtainsSearchRepository : ICurtainsSearchRepository
{

    private readonly ElasticClient _elasticClient;

    public CurtainsSearchRepository(ElasticClient elasticsearchClient)
    {
        _elasticClient = elasticsearchClient;
    }

    public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsBySunProtection(string indexName, bool sunProtection)
    {
        var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
            .Index(indexName)
                .Query(q => q
                    .Bool(t => t)
                )
            );
        return response;
    }

    public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByFabric(string indexName, string fabricId)
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
    }
}