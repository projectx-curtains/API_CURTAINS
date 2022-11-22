using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO.Filters
{
    /// <summary>
    ///  This class describes bedspreads filter.
    /// </summary>
    public class BedspreadsFilter : BaseFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents fabric kinds filters.
        /// </summary>
        public Dictionary<int, string> FabricKinds { get; set; }
        /// <summary>
        ///  This property represents fabric materials filters.
        /// </summary>
        public Dictionary<int, string> FabricMaterials { get; set; }

        //TODO density

        /// <summary>
        ///  This property represents sizes filters.
        /// </summary>
        public Dictionary<int, string> Sizes { get; set; }
        /// <summary>
        ///  This property represents designs filters.
        /// </summary>
        public Dictionary<int, string> Designs { get; set; }
        #endregion
    }
}
