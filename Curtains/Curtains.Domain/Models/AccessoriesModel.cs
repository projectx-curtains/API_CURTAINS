namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes accessories model.
    /// </summary>
    public class AccessoriesModel : BaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents the furniture id column.
        /// </summary>
        public int? FurnitureId { get; set; }
        /// <summary>
        ///  This property represents the bracing id column.
        /// </summary>
        public int? BracingId { get; set; }
        /// <summary>
        ///  This property represents the color group id column.
        /// </summary>
        public int? ColorGroupId { get; set; }
        /// <summary>
        ///  This property represents the manufacturer id column.
        /// </summary>
        public int? ManufacturerId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents the furniture of accessories.
        /// </summary>
        public virtual FurnitureModel Furniture { get; set; }
        /// <summary>
        ///  This property represents the bracing of accessories.
        /// </summary>
        public virtual BracingModel Bracing { get; set; }
        /// <summary>
        ///  This property represents the color group of accessories.
        /// </summary>
        public virtual ColorGroupModel ColorGroup { get; set; }
        /// <summary>
        ///  This property represents the manufacturer of accessories.
        /// </summary>
        public virtual ManufacturerModel Manufacturer { get; set; }
        #endregion
    }
}
