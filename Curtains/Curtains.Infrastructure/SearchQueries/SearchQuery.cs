using MediatR;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.SearchQueries
{
    public class SearchQuery<T> : IRequest<ICurtainsSearchRepository>
    {
        public string Search { get; set; }
        public int MinPrice { get; set; } = 1;
        public int MaxPrice { get; set; } = 10000;
        public int MinWidth { get; set; } = 1;
        public int MaxWidth { get; set; } = 10000;
        public int MinHeight { get; set; } = 1;
        public int MaxHeight { get; set; } = 10000;
        public OrderBy? Order { get; set; }
        public int Take { get; set; } = 30;
        public int Skip { get; set; }
    }
}
