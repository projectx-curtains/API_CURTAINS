namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> DesignDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class DesignDTO : BaseExtendedByTitleDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents presence of design.
        /// </summary>
        public bool Presence { get; set; }
        #endregion
    }
}
