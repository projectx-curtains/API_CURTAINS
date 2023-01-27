using Curtains.Domain.Projections;
using Nest;

namespace Curtains.Infrastructure.SearchQueries
{
    public class SearchResults<T>
    {
        public IReadOnlyDictionary<string, IReadOnlyCollection<string>> Highlight { get; set; }
        public CurtainsProjection Result { get; set; }
    }
}
