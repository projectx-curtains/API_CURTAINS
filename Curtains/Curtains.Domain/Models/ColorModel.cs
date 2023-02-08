﻿namespace Curtains.Domain.Models
{
    public class ColorModel : ExtendedBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents code of color.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///  This property represents code of color group.
        /// </summary>
        public string ColorGroup { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of fabrics with that color.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; }
        /// <summary>
        ///  This property represents list of accessories with that color.
        /// </summary>
        public virtual ICollection<AccessoriesModel> Accessories { get; }
        #endregion
    }
}
