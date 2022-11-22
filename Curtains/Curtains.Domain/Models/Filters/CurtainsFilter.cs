using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models.Filters
{
    public class CurtainsFilter : BaseFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents fabric types filters.
        /// </summary>
        public Dictionary<int, string> FabricTypes { get; set; }
        /// <summary>
        ///  This property represents curtains types filters.
        /// </summary>
        public Dictionary<int, string> CurtainsTypes { get; set; }
        /// <summary>
        ///  This property represents curtains kinds filters.
        /// </summary>
        public Dictionary<int, string> CurtainsKinds { get; set; }
        /// <summary>
        ///  This property represents curtains purposes filters.
        /// </summary>
        public Dictionary<int, string> Purposes { get; set; }
        /// <summary>
        ///  This property represents fabric kinds filters.
        /// </summary>
        public Dictionary<int, string> FabricKinds { get; set; }
        /// <summary>
        ///  This property represents fabric materials filters.
        /// </summary>
        public Dictionary<int, string> FabricMaterials { get; set; }

        //TODO density, sun protection

        /// <summary>
        ///  This property represents curtains height filters.
        /// </summary>
        public Dictionary<int, int> Height { get; set; }
        /// <summary>
        ///  This property represents curtains width filters.
        /// </summary>
        public Dictionary<int, string> Width { get; set; }
        /// <summary>
        ///  This property represents designs filters.
        /// </summary>
        public Dictionary<int, string> Designs { get; set; }
        /// <summary>
        ///  This property represents bracings filters.
        /// </summary>
        public Dictionary<int, string> Bracings { get; set; }
        #endregion
    }
}
