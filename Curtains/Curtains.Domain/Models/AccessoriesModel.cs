namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes accessories model.
    /// </summary>
    public class AccessoriesModel : BaseEntity
    {
        #region PropertiesRegion
        public int FurnitureId { get; set; }
        public int BracingId { get; set; }
        /// <summary>
        ///  This property represents the color group id column.
        /// </summary>
        public int ColorGroupId { get; set; }
        public int ManufacturerId { get; set; }
        #endregion

        #region NavigationProperties
        public virtual FurnitureModel Furniture { get; }
        public virtual BracingModel Bracing { get; }
        public virtual ColorGroupModel ColorGroup { get; }
        public virtual ManufacturerModel Manufacturer { get; }
        #endregion
    }
}
