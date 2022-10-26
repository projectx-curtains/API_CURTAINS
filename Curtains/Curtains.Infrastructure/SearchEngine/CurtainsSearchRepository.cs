using Curtains.Domain.Search;
using Nest;
using Curtains.Domain.Projections;

namespace Curtains.Infrastructure.SearchEngine;

public class CurtainsSearchRepository : ICurtainsSearchRepository
{
    
    private readonly ElasticClient _elasticClient;

    public CurtainsSearchRepository(ElasticClient elasticsearchClient)
    {
        _elasticClient = elasticsearchClient;
    }

    public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByPriceRange(string indexName,
        int priceLowerLimit, int priceHigherLimit)
    {
        var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
            .Index(indexName)
            .Query(q => q
                .Range(m => m
                    .Field(f => f.Price)
                    .GreaterThan(priceLowerLimit)
                    .LessThan(priceHigherLimit)
                )
            )
        );
        return response;
    }

    public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsByPurpose(string indexName,
        string purpose)
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

    public async Task<ISearchResponse<CurtainsProjection>> GetCurtainsBySunProtection(string indexName, bool sunProtection)
    {
        var response = await _elasticClient.SearchAsync<CurtainsProjection>(s => s
            .Index(indexName)
            .Query(q => q
                .Term(t => t
                    .Field(f => f.SunProtection)
                    .Value(sunProtection)
                )
            )
        );
        return response;
    }
    
}