using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ConsistencyModel : BaseEntity
    {
        public ConsistencyModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        #region NavigationPropertiesRegion
        public virtual ICollection<FabricModel> Fabrics { get; set; }
        #endregion

    }
}
