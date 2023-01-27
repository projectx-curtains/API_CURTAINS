using MediatR;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.SearchQueries
{

    public class SearchQuery<T> : IRequest<ICurtainsSearchRepository>
    {
        public string Search { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public OrderBy? OrderBy { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
