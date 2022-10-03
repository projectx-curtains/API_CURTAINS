using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes curtains type model.
    /// </summary>
    public class CurtainsTypeModel : BaseEntity
    {
        public CurtainsTypeModel()
        {
            Curtains = new HashSet<CurtainsModel>();
        }

        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains of that type.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        #endregion
    }
}
