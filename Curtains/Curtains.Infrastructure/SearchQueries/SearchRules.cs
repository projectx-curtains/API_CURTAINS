using Curtains.Domain.Projections;

namespace Curtains.Infrastructure.SearchQueries
{
    public static class SearchRules
    {
        public static readonly string[] CurtainsSearchFields =
        {
            nameof(CurtainsProjection.Color).ToLower(),
            nameof(CurtainsProjection.CurtainsType).ToLower(),
            nameof(CurtainsProjection.CurtainsKind).ToLower(),
            nameof(CurtainsProjection.Material).ToLower(),
            nameof(CurtainsProjection.Fabric).ToLower(),
            nameof(CurtainsProjection.Purpose).ToLower()
        };
    }
}
