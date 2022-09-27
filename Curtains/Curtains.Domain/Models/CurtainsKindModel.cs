using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class CurtainsKindModel : BaseEntity
    {
        public CurtainsKindModel()
        {
            Curtains = new HashSet<CurtainsModel>();
        }

        #region NavigationPropertiesRegion
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        #endregion
    }
}
