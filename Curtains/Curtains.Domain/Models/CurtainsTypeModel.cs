namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes curtains type model.
    /// </summary>
    public class CurtainsTypeModel : ExtendedByTitleBaseEntity
    {
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains of that type.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; }
        #endregion
    }
}
