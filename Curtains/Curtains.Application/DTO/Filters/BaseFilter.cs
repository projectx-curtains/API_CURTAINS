using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO.Filters
{
    /// <summary>
    ///  This class describes base filter.
    /// </summary>
    public class BaseFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents marketing info filters.
        /// </summary>
        public List<string> MarketingInfo { get; set; }

        /// <summary>
        ///  This property represents minimum price.
        /// </summary>
        public decimal MinPrice { get; set; }

        /// <summary>
        ///  This property represents maximum price.
        /// </summary>
        public decimal MaxPrice { get; set; }

        /// <summary>
        ///  This property represents colors filters.
        /// </summary>
        public Dictionary<int, string> Colors { get; set; }
        #endregion
    }
}
