using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models.Filters
{
    /// <summary>
    ///  This class describes curtains kind filter.
    /// </summary>
    public class CurtainsKindFilter
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents curtains kind Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  This property represents curtains kind title.
        /// </summary>
        public string Title { get; set; }
        #endregion
    }
}
