namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes lambrequins model.
    /// </summary>
    public class LambrequinsModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents ColorId column.
        /// </summary>
        public int? ColorId { get; set; }
        /// <summary>
        ///  This property represents price of lambrequins.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents design id column.
        /// </summary>
        public int? DesignId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents color group of lambrequins.
        /// </summary>
        public virtual ColorModel Color { get; set; }
        /// <summary>
        ///  This property represents design of lambrequins.
        /// </summary>
        public virtual DesignModel Design { get; set; }
        /// <summary>
        ///  This property represents product sets with this lambrequin.
        /// </summary>
        public virtual ICollection<ProductSetModel> ProductSets { get; }
        #endregion
    }
}
