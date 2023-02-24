using MediatR;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.SearchQueries
{
    public class SearchQuery<T> : IRequest<ICurtainsSearchRepository>
    {
        public string Search { get; set; }
        public int MinPrice { get; set; } 
        public int MaxPrice { get; set; } 
        public int MinWidth { get; set; } 
        public int MaxWidth { get; set; } 
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public OrderBy? Order { get; set; }
        public int Take { get; set; } 
        public int Skip { get; set; }
    }
}
