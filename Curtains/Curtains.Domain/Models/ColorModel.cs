using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ColorModel : BaseEntity
    {
        /// <summary>
        ///  This class describes color of products like fabrics, accessories and lambrequins.
        /// </summary>
        public ColorModel()
        {
            Fabrics = new HashSet<FabricModel>();
            Accessories = new HashSet<AccessoriesModel>();
            Lambrequins = new HashSet<LambrequinsModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents code of color.
        /// </summary>
        public string Code { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of fabrics with that color.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; set; }
        /// <summary>
        ///  This property represents list of accessories with that color.
        /// </summary>
        public virtual ICollection<AccessoriesModel> Accessories { get; set; }
        /// <summary>
        ///  This property represents list of lamrequins with that color.
        /// </summary>
        public virtual ICollection<LambrequinsModel> Lambrequins { get; set; }
        #endregion
    }
}
