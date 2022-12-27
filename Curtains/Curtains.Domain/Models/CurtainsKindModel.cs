namespace Curtains.Domain.Models
{
    public class CurtainsKindModel : ExtendedBaseEntity
    {
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains with that kind.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; }
        #endregion
    }
}
