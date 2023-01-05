namespace Curtains.Domain.Models
{
    public class CurtainsModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if curtains are sun-protected or not.
        /// </summary>
        public bool SunProtection { get; set; }
        /// <summary>
        ///  This property represents height of curtains.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        ///  This property represents width of curtains.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents FabricId column.
        /// </summary>
        public int FabricId { get; set; }
        /// <summary>
        ///  This property represents MaterialId column.
        /// </summary>
        public int MaterialId { get; set; }
        /// <summary>
        ///  This property represents AccessoriesId column.
        /// </summary>
        public int AccessoriesId { get; set; }
        /// <summary>
        ///  This property represents CurtainsTypeId column.
        /// </summary>
        public int CurtainsTypeId { get; set; }
        /// <summary>
        ///  This property represents CurtainsKindId column.
        /// </summary>
        public int CurtainsKindId { get; set; }
        /// <summary>
        ///  This property represents price of curtains.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents purpose of curtains.
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        ///  This property represents ColorId column.
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        ///  This property represents BracingId column.
        /// </summary>
        public int BracingId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents fabric of curtains.
        /// </summary>
        public virtual FabricModel Fabric { get; set; }
        /// <summary>
        ///  This property represents material of curtains.
        /// </summary>
        public virtual MaterialModel Material { get; set; }
        /// <summary>
        ///  This property represents accessories of curtains.
        /// </summary>
        public virtual AccessoriesModel Accessories { get; set; }
        /// <summary>
        ///  This property represents type of curtains.
        /// </summary>
        public virtual CurtainsTypeModel CurtainsType { get; set; }
        /// <summary>
        ///  This property represents kind of curtains.
        /// </summary>
        public virtual CurtainsKindModel CurtainsKind { get; set; }
        /// <summary>
        ///  This property represents of Bracing.
        /// </summary>
        public virtual BracingModel Bracing { get; set; }
        /// <summary>
        ///  This property represents of Color.
        /// </summary>
        public virtual ColorModel Color { get; set; }
        /// <summary>
        ///  This property represents sets with that curtains.
        /// </summary>
        public virtual ICollection<ProductSetModel> ProductSets { get; }
        /// <summary>
        ///  This property represents product images with that curtains.
        /// </summary>
        public virtual ICollection<ProductImageModel> ProductImages { get; }
        #endregion
    }
}
