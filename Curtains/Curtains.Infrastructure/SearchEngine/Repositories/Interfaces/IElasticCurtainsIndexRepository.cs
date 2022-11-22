using Curtains.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Interfaces
{
    public interface IElasticCurtainsIndexRepository
    {
        public bool Index(CurtainsModel model, string indexName);
        public bool Delete(CurtainsModel model, string indexName);
    }
}

