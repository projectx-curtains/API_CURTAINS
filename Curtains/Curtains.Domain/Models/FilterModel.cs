using Curtains.Domain.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes filer model.
    /// </summary>
    public class FilterModel
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents color filter.
        /// </summary>
        public ColorFilter ColorFilter { get; set; }
        /// <summary>
        ///  This property represents the lowest price.
        /// </summary>
        public decimal? MinPriceFilter { get; set; }
        /// <summary>
        ///  This property represents the highest price.
        /// </summary>
        public decimal? MaxPriceFilter { get; set; }
        /// <summary>
        ///  This property represents curtains type filter.
        /// </summary>
        public CurtainsTypeFilter CurtainsTypeFilter { get; set; }
        /// <summary>
        ///  This property represents curtains kind filter.
        /// </summary>
        public CurtainsKindFilter CurtainsKindFilter { get; set; }
        /// <summary>
        ///  This property represents purpose filter.
        /// </summary>
        public string PurposeFilter { get; set; }
        /// <summary>
        ///  This property represents fabric consistency filter.
        /// </summary>
        public FabricConsistencyFilter FabricConsistencyFilter { get; set; }
        /// <summary>
        ///  This property represents fabric density filter.
        /// </summary>
        public bool FabricDensityFilter { get; set; }
        /// <summary>
        ///  This property represents sun protection filter.
        /// </summary>
        public bool SunProtectionFilter { get; set; }
        /// <summary>
        ///  This property represents height filter.
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        ///  This property represents width filter.
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        ///  This property represents pillows size filter.
        /// </summary>
        public string PillowsSize { get; set; }
        /// <summary>
        ///  This property represents accessories filter.
        /// </summary>
        public AccessoriesFilter AccessoriesFilter { get; set; }
        #endregion
    }
}
