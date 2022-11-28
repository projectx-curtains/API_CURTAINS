namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes bedspreads model.
    /// </summary>
    public class BedspreadsModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents size of bedspreads.
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        ///  This property represents purpose of bedspreads.
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        ///  This property represents price of bedspreads.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents FabricId column.
        /// </summary>
        public int FabricId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents fabric of bedspreads.
        /// </summary>
        public virtual FabricModel Fabric { get; set; }
        /// <summary>
        ///  This property represents ProductImage of bedspreads.
        /// </summary>
        public virtual ICollection<ProductImageModel> ProductImages { get; } = new List<ProductImageModel>();
        /// <summary>
        ///  This property represents product sets with bedspreads.
        /// </summary>
        public virtual ICollection<ProductSetModel> ProductSets { get; } = new List<ProductSetModel>();
        #endregion
    }
}
