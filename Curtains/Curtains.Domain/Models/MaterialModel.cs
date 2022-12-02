namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes material model.
    /// </summary>
    public class MaterialModel : ExtendedBaseEntity
    {
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains with that material.
        /// </summary>
        public virtual ICollection<CurtainModel>? Curtains { get; }
        /// <summary>
        ///  This property represents list of fabrics with that material.
        /// </summary>
        public virtual ICollection<FabricModel>? Fabrics { get; }
        #endregion
    }
}
