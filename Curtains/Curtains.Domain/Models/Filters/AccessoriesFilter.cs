using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models.Filters
{
    /// <summary>
    ///  This class describes accessories filter.
    /// </summary>
    public class AccessoriesFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents accessories Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  This property represents accessories title.
        /// </summary>
        public string Title { get; set; }
        #endregion
    }
}
