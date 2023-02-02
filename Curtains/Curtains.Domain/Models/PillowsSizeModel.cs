namespace Curtains.Domain.Models
{
    public class PillowsSizeModel : ExtendedByTitleBaseEntity
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
