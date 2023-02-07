using System.ComponentModel.DataAnnotations.Schema;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes model of image product.
    /// </summary>
    public class ProductImageModel : BaseEntity
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
        public virtual CurtainsModel? Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows, which image is presented.
        /// </summary>
        public virtual PillowsModel? Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads, which image is presented.
        /// </summary>
        public virtual BedspreadsModel? Bedspreads { get; set; }
        /// <summary>
        ///  This property represents product sets, which image is presented.
        /// </summary>
        public virtual ProductSetModel? ProductSet { get; set; }
        /// <summary>
        ///  This property represents fabrics, which image is presented.
        /// </summary>
        public virtual FabricModel? Fabrics { get; set; }
        /// <summary>
        ///  This property represents marketing info of this product.
        /// </summary>
        public virtual MarketingInfoModel MarketingInfo { get; set; }
        #endregion
    }
}
