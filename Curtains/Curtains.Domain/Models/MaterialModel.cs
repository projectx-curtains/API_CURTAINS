using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes material model.
    /// </summary>
    public class MaterialModel : ExtendedBaseEntity
    {
        public MaterialModel()
        {
            Curtains = new HashSet<CurtainsModel>();
        }

        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains with that material.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        #endregion
    }
}
