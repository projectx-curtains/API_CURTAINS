using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.Shared.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

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
