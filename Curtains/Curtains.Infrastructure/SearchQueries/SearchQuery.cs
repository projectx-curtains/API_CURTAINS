using MediatR;
using Curtains.Infrastructure.Interfaces;

namespace Curtains.Infrastructure.SearchQueries
{

    public class SearchQuery<T> : IRequest<ICurtainsSearchRepository>
    {
        public string Search { get; set; }
        public string Sort{ get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
