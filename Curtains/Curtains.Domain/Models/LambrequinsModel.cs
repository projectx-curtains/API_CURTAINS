namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes lambrequins model.
    /// </summary>
    public class LambrequinsModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents ColorGroupId column.
        /// </summary>
        public int ColorGroupId { get; set; }
        /// <summary>
        ///  This property represents price of lambrequins.
        /// </summary>
        public decimal Price { get; set; }
        public int DesignId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents color group of lambrequins.
        /// </summary>
        public virtual ColorModel ColorGroup { get; set; }
        public virtual DesignModel Design { get; set; }
        /// <summary>
        ///  This property represents product sets with this lambrequin.
        /// </summary>
        public virtual ICollection<ProductSetModel> ProductSets { get; }
        #endregion
    }
}
