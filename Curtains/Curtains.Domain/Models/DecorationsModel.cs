using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes decorations model.
    /// </summary>
    public class DecorationsModel : BaseEntity
    {
        public DecorationsModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if there are decorations on fabric or not.
        /// </summary>
        public bool Presence { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of fabrics with that decorations.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; set; }
        #endregion
    }
}
