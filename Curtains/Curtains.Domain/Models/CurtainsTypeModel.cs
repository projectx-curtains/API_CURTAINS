namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes curtains type model.
    /// </summary>
    public class CurtainsTypeModel : ExtendedBaseEntity
    {
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains of that type.
        /// </summary>
        public virtual ICollection<CurtainModel>? Curtains { get; }
        #endregion
    }
}
