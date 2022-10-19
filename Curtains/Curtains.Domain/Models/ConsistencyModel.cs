using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ConsistencyModel : BaseEntity
    {
        /// <summary>
        ///  This class describes consistency model.
        /// </summary>
        public ConsistencyModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of fabrics with that consistency.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; set; }
        #endregion

    }
}
