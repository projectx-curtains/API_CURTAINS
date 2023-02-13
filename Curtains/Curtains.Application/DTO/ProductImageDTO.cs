using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> ProductImageDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class ProductImageDTO : BaseDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents path to image of product.
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        ///  This property represents CurtainsId.
        /// </summary>
        public int? CurtainsId { get; set; }
        /// <summary>
        ///  This property represents PillowsId.
        /// </summary>
        public int? PillowsId { get; set; }
        /// <summary>
        ///  This property represents BedspreadsId.
        /// </summary>
        public int? BedspreadsId { get; set; }
        /// <summary>
        ///  This property represents SetsId.
        /// </summary>
        public int? ProductSetId { get; set; }
        /// <summary>
        ///  This property represents FabricId.
        /// </summary>
        public int? FabricsId { get; set; }

        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents curtains, which image is presented.
        /// </summary>
        public CurtainsDTO? Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows, which image is presented.
        /// </summary>
        public PillowsDTO? Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads, which image is presented.
        /// </summary>
        public BedspreadsDTO? Bedspreads { get; set; }
        /// <summary>
        ///  This property represents product sets, which image is presented.
        /// </summary>
        public ProductSetDTO? ProductSet { get; set; }
        /// <summary>
        ///  This property represents fabrics, which image is presented.
        /// </summary>
        public FabricDTO? Fabrics { get; set; }
        /// <summary>
        ///  This property represents marketing info of this product.
        /// </summary>
        public MarketingInfoDTO MarketingInfo { get; set; }
        #endregion
    }
}