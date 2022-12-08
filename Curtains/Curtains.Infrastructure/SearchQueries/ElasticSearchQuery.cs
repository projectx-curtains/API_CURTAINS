using Curtains.Domain.Search;

namespace Curtains.Infrastructure.SearchQueries
{
    public class ElasticSearchQuery<T> : SearchQuery<T>
    {
        public Filter Filters { get; set; } = null;
    }
}
