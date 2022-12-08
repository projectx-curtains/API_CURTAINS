namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes model of set of products.
    /// </summary>
    public class ProductSetModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents CurtainsId column.
        /// </summary>
        public int? CurtainsId { get; set; }
        /// <summary>
        ///  This property represents PillowsId column.
        /// </summary>
        public int? PillowsId { get; set; }
        /// <summary>
        ///  This property represents BedspreadsId column.
        /// </summary>
        public int? BedspreadsId { get; set; }
        /// <summary>
        ///  This property represents LabmvrequinsId column.
        /// </summary>
        public int? LambrequinsId { get; set; }
        /// <summary>
        ///  This property represents price of product set.
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents curtains in that product set.
        /// </summary>
        public virtual CurtainModel? Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows in that product set.
        /// </summary>
        public virtual PillowsModel? Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads in that product set.
        /// </summary>
        public virtual BedspreadsModel? Bedspreads { get; set; }
        /// <summary>
        ///  This property represents lambrequin in that set.
        /// </summary>
        public virtual LambrequinsModel? Lambrequins { get; set; }
        /// <summary>
        ///  This property represents product images with this sets.
        /// </summary>
        public virtual ICollection<ProductImageModel> ProductImages { get; }
        #endregion
    }
}
