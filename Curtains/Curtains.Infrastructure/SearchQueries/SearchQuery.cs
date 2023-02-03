using MediatR;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.SearchQueries
{
    public class SearchQuery<T> : IRequest<ICurtainsSearchRepository>
    {
        public string Search { get; set; }
        public int MinPrice { get; set; } = 1;
        public int MaxPrice { get; set; } = 1000;
        public OrderBy? Order { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
