namespace Curtains.Application.DTO
{
    public class LambrequinsDTO : BaseExtendedDTO
    {
       #region PropertiesRegion
        /// <summary>
        ///  This property represents price of lambrequins.
        /// </summary>
        public decimal Price { get; set; }
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
