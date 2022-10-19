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
    public class MaterialModel : BaseEntity
    {
        public MaterialModel()
        {
            Curtains = new HashSet<CurtainsModel>();
        }

        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains with that material.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        #endregion
    }
}
