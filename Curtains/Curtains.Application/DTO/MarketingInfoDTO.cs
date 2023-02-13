using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> MarketingInfoDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class MarketingInfoDTO : BaseDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if product is new or not.
        /// </summary>
        public bool IsNew { get; set; }
        /// <summary>
        ///  This property represents situation, if product is on sale or not.
        /// </summary>
        public bool IsSale { get; set; }
        /// <summary>
        ///  This property represents situation, if product is popular or not.
        /// </summary>
        public bool IsPopular { get; set; }
        /// <summary>
        ///  This property represents Id field for ProductImage.
        /// </summary>
        public int? ProductImageId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents products, which marketing information is presented.
        /// </summary>
        public ProductImageDTO ProductImage { get; set; }
        #endregion
    }
}