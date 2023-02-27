namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> PillowsSizeDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class PillowsSizeDTO : BaseExtendedDTO
    {
        /// <summary>
        ///  This property represents legnth of pillow.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///  This property represents width of pillow.
        /// </summary>
        public int Width { get; set; }
    }
}