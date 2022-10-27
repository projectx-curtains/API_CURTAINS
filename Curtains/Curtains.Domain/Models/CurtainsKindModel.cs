namespace Curtains.Domain.Models
{
    public class CurtainsKindModel : ExtendedBaseEntity
    {
        /// <summary>
        ///  This class describes curtains kind model.
        /// </summary>
        public CurtainsKindModel()
        {
            Curtains = new HashSet<CurtainsModel>();
        }

        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of curtains with that kind.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        #endregion
    }
}
