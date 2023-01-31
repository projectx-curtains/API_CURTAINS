namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes decorations model.
    /// </summary>
    public class DecorationsModel : ExtendedByTitleBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if there are decorations on fabric or not.
        /// </summary>
        public bool Presence { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of fabrics with that decorations.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; }
        #endregion
    }
}
