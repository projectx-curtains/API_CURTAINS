using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ManufacturerModel : BaseEntity
    {
        public ManufacturerModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }
        #region PropertiesRegion

        public string Country { get; set; } = null!;

        public virtual ICollection<FabricModel> Fabrics { get; set; }
        #endregion
    }
}
