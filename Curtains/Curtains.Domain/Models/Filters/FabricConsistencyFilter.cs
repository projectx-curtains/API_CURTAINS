using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models.Filters
{
    /// <summary>
    ///  This class describes fabric consistency filter.
    /// </summary>
    public class FabricConsistencyFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents fabric consistency Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  This property represents fabric consistency title.
        /// </summary>
        public string Title { get; set; }
        #endregion
    }
}
