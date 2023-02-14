using Curtains.Domain.Projections;

namespace Curtains.Infrastructure.SearchQueries
{
    public static class SearchRules
    {
        public static readonly string[] CurtainsSearchFields =
        {
			nameof(CurtainsProjection.Fabric).ToLower(),
			nameof(CurtainsProjection.CurtainsType).ToLower(),
			nameof(CurtainsProjection.CurtainsKind).ToLower(),
			nameof(CurtainsProjection.Purpose).ToLower(),
			nameof(CurtainsProjection.Material).ToLower(),
			nameof(CurtainsProjection.FabricStructure).ToLower(),
			nameof(CurtainsProjection.Color).ToLower(),
			nameof(CurtainsProjection.Desing).ToLower(),
			nameof(CurtainsProjection.Bracing).ToLower()
		};
    }
}
