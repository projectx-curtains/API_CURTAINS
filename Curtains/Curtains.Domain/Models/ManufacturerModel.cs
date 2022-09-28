using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes manufacturer model.
    /// </summary>
    public class ManufacturerModel : BaseEntity
    {
        public ManufacturerModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents country of manufacturer.
        /// </summary>
        public string Country { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of fabrics with that manufacturer.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; set; }
        #endregion
    }
}
