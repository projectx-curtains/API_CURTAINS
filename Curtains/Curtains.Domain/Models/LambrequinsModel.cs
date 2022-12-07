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
        public int ColorId { get; set; }
        /// <summary>
        ///  This property represents price of lambrequins.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents bracingId of lambrequins.
        /// </summary>
        public int BracingId { get; set; }
        /// <summary>
        ///  This property represents kind of lambrequins.
        /// </summary>
        public int FabricKindId { get; set; }
        /// <summary>
        ///  This property represents height of lambrequins.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        ///  This property represents width of lambrequins.
        /// </summary>
        public int Width { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents color of lambrequins.
        /// </summary>
        public virtual ColorModel Color { get; set; }
        /// <summary>
        ///  This property represents bracing of lambrequins.
        /// </summary>
        public virtual BracingModel Bracing { get; set; }
        /// <summary>
        ///  This property represents fabricKind of lambrequins.
        /// </summary>
        public virtual FabricKindModel FabricKind { get; set; }
        /// <summary>
        ///  This property represents product sets with this lambrequin.
        /// </summary>
        public virtual ICollection<ProductSetModel> ProductSets { get; }
        #endregion
    }
}
