namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes fabric model.
    /// </summary>
    public class FabricModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if fabric is dense or not.
        /// </summary>
        public bool Density { get; set; }
        /// <summary>
        ///  This property represents ConsistencyId column.
        /// </summary>
        public int ConsistencyId { get; set; }
        /// <summary>
        ///  This property represents ColorId column.
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        ///  This property represents DecorationId column.
        /// </summary>
        public int DecorationsId { get; set; }
        /// <summary>
        ///  This property represents ManufacturerId column.
        /// </summary>
        public int ManufacturerId { get; set; }
        /// <summary>
        ///  This property represents price of fabric.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents length of fabric.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///  This property represents wifth of fabric.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents designId of fabric.
        /// </summary>
        public int DesignId { get; set; }
        /// <summary>
        ///  This property represents FabricTypeId of fabric.
        /// </summary>
        public int FabricTypeId { get; set; }
        /// <summary>
        ///  This property represents FabricKindId of fabric.
        /// </summary>
        public int FabricKindId { get; set; }
        /// <summary>
        ///  This property represents MaterialId of fabric.
        /// </summary>
        public int MaterialId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents consistency of fabric.
        /// </summary>
        public virtual ConsistencyModel Consistency { get; set; }
        /// <summary>
        ///  This property represents color of fabric.
        /// </summary>
        public virtual ColorModel Color { get; set; }
        /// <summary>
        ///  This property represents decoration of fabric.
        /// </summary>
        public virtual DecorationsModel Decorations { get; set; }
        /// <summary>
        ///  This property represents design of fabric.
        /// </summary>
        public virtual DesignModel Design { get; set; }
        /// <summary>
        ///  This property represents kind of fabric.
        /// </summary>
        public virtual FabricKindModel FabricKind { get; set; }
        /// <summary>
        ///  This property represents type of fabric.
        /// </summary>
        public virtual FabricTypeModel FabricType { get; set; }
        /// <summary>
        ///  This property represents material of fabric.
        /// </summary>
        public virtual MaterialModel Material { get; set; }
        /// <summary>
        ///  This property represents manufacturer of fabric.
        /// </summary>
        public virtual ManufacturerModel Manufacturer { get; set; }
        /// <summary>
        ///  This property represents list of curtains with that fabric.
        /// </summary>
        public virtual ICollection<CurtainModel> Curtains { get; set; }
        /// <summary>
        ///  This property represents list of bedspreads with that fabric.
        /// </summary>
        public virtual ICollection<BedspreadsModel> Bedspreads { get; set; }
        /// <summary>
        ///  This property represents list of pillows with that fabric.
        /// </summary>
        public virtual ICollection<PillowsModel> Pillows { get; set; }
        /// <summary>
        ///  This property represents product images of fabric.
        /// </summary>
        public virtual ICollection<ProductImageModel> ProductImages { get; }
        #endregion
    }
}
