using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class MaterialModel : BaseEntity
    {
        public MaterialModel()
        {
            Curtains = new HashSet<CurtainsModel>();
        }
        #region PropertiesRegion

        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        #endregion
    }
}
