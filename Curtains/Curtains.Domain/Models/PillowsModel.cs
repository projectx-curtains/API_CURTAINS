namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes pillows model.
    /// </summary>
    public class PillowsModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents FabricId column.
        /// </summary>
        public int FabricId { get; set; }
        /// <summary>
        ///  This property represents size of pillows.
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        ///  This property represents filler of pillows.
        /// </summary>
        public string Filler { get; set; }
        /// <summary>
        ///  This property represents situation, if cover of pillows is removable.
        /// </summary>
        public bool RemovableCover { get; set; }
        /// <summary>
        ///  This property represents price of pillows.
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents fabric of pillows.
        /// </summary>
        public virtual FabricModel Fabric { get; set; }
        /// <summary>
        ///  This property represents product image about pillows.
        /// </summary>
        public virtual ICollection<ProductImageModel>? ProductImages { get; }
        /// <summary>
        ///  This property represents list of product sets with that pillows.
        /// </summary>
        public virtual ICollection<ProductSetModel>? ProductSets { get; }
        #endregion
    }
}
