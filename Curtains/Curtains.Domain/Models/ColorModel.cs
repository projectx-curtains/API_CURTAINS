using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ColorModel : BaseEntity
    {
        public ColorModel()
        {
            Fabrics = new HashSet<FabricModel>();
            Accessories = new HashSet<AccessoriesModel>();
            Lambrequins = new HashSet<LambrequinsModel>();
        }

        #region PropertiesRegion
        public string Code { get; set; }
        #endregion

        #region NavigationProperties
        public virtual ICollection<FabricModel> Fabrics { get; set; }
        public virtual ICollection<AccessoriesModel> Accessories { get; set; }
        public virtual ICollection<LambrequinsModel> Lambrequins { get; set; }
        #endregion
    }
}
