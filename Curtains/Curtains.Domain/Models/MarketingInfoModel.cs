using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes marketing information model.
    /// </summary>
    public class MarketingInfoModel : BaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if product is new or not.
        /// </summary>
        public bool IsNew { get; set; }
        /// <summary>
        ///  This property represents situation, if product is on sale or not.
        /// </summary>
        public bool IsOnSale { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents curtains, which marketing information is described.
        /// </summary>
        public virtual CurtainsModel Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows, which marketing information is described.
        /// </summary>
        public virtual PillowsModel Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads, which marketing information is described.
        /// </summary>
        public virtual BedspreadsModel Bedspreads { get; set; }
        /// <summary>
        ///  This property represents product sets, which marketing information is described.
        /// </summary>
        public virtual ProductSetModel Sets { get; set; }
        #endregion
    }
}
