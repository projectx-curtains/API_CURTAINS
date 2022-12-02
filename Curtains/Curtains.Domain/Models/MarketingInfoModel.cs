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
        /// <summary>
        ///  This property represents situation, if product is popular or not.
        /// </summary>
        public bool IsPopular { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents ProductImage.
        /// </summary>
        public virtual ProductImageModel ProductImage { get; set; } = null!;
        #endregion
    }
}
