using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models.Filters
{
    /// <summary>
    ///  This class describes curtains type filter.
    /// </summary>
    public class CurtainsTypeFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents curtains type Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  This property represents curtains type title.
        /// </summary>
        public string Title { get; set; }
        #endregion
    }
}
