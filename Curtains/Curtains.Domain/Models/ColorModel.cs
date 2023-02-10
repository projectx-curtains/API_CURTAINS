namespace Curtains.Domain.Models
{
    public class ColorModel : ExtendedByTitleBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents code of color.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///  This property represents Color group id column.
        /// </summary>
        public int? ColorGroupId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents color group of that color.
        /// </summary>
        public virtual ColorGroupModel ColorGroup { get; }
        #endregion
    }
}
