using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models.Filters
{
    /// <summary>
    ///  This class describes base filter.
    /// </summary>
    public class BaseFilter
    {
        #region PropertiesRegion
        //TODO marketingInfo
         
        /// <summary>
        ///  This property represents colors filters.
        /// </summary>
        public Dictionary<int, string> Colors { get; set; }
        #endregion
    }
}
