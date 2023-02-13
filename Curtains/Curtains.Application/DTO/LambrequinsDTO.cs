namespace Curtains.Application.DTO
{
    public class LambrequinsDTO : BaseExtendedDTO
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
        public ColorDTO Color { get; set; }
        /// <summary>
        ///  This property represents design of lambrequins.
        /// </summary>
        public DesignDTO Design { get; set; }
        #endregion
    }
}
