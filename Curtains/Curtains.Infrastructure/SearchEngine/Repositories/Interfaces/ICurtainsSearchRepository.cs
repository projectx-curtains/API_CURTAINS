using Curtains.Domain.Projections;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface ICurtainsSearchRepository
    {
        public Task<List<CurtainsProjection>> GetCurtains(CurtainsProjection model, string indexName);
    }
}
