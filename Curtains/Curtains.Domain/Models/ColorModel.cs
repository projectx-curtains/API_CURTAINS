namespace Curtains.Domain.Models
{
    public class ColorModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents code of color.
        /// </summary>
        public string Code { get; set; } = null!;
        /// <summary>
        ///  This property represents code of color group.
        /// </summary>
        public string ColorGroup { get; set; } = null!;
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of fabrics with that color.
        /// </summary>
        public virtual ICollection<FabricModel>? Fabrics { get; }
        /// <summary>
        ///  This property represents list of accessories with that color.
        /// </summary>
        public virtual ICollection<AccessoriesModel>? Accessories { get; }
        /// <summary>
        ///  This property represents list of Curtains with that color.
        /// </summary>
        public virtual ICollection<CurtainModel>? Curtains { get; }
        #endregion
    }
}
