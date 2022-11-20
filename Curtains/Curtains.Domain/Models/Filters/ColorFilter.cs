using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models.Filters
{
    /// <summary>
    ///  This class describes color filter.
    /// </summary>
    public class ColorFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents color Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  This property represents color title.
        /// </summary>
        public string Title { get; set; }
        #endregion
    }
}
