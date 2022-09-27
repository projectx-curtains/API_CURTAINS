using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class DecorationsModel : BaseEntity
    {
        public DecorationsModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        #region PropertiesRegion
        public bool Presence { get; set; }
        #endregion

        #region NavigationProperties
        public virtual ICollection<FabricModel> Fabrics { get; set; }
        #endregion
    }
}
