namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> FabricDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class FabricDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if fabric is dense or not.
        /// </summary>
        public bool Density { get; set; }
        /// <summary>
        ///  This property represents ColorId column.
        /// </summary>
        public int? ColorId { get; set; }
        /// <summary>
        ///  This property represents DecorationId column.
        /// </summary>
        public int? DecorationsId { get; set; }
        /// <summary>
        ///  This property represents ManufacturerId column.
        /// </summary>
        public int? ManufacturerId { get; set; }
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
        public int? DesignId { get; set; }
        /// <summary>
        ///  This property represents MaterialId of fabric.
        /// </summary>
        public int? MaterialId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents color of fabric.
        /// </summary>
        public ColorDTO Color { get; set; }
        /// <summary>
        ///  This property represents decoration of fabric.
        /// </summary>
        public DecorationsDTO Decorations { get; set; }
        /// <summary>
        ///  This property represents design of fabric.
        /// </summary>
        public DesignDTO Design { get; set; }
        /// <summary>
        ///  This property represents material of fabric.
        /// </summary>
        public MaterialDTO Material { get; set; }
        /// <summary>
        ///  This property represents manufacturer of fabric.
        /// </summary>
        public ManufacturerDTO Manufacturer { get; set; }
        #endregion
    }
}