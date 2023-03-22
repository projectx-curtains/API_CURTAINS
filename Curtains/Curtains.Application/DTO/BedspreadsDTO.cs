namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> BedspreadsDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class BedspreadsDTO : BaseExtendedDTO
    {
       #region PropertiesRegion
        /// <summary>
        ///  This property represents purpose of bedspreads.
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        ///  This property represents price of bedspreads.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents size of bedspreads.
        /// </summary>
        public BedspreadsSizeDTO Size { get; set; }
        /// <summary>
        ///  This property represents fabric of bedspreads.
        /// </summary>
        public FabricDTO Fabric { get; set;}
        #endregion
    }
}