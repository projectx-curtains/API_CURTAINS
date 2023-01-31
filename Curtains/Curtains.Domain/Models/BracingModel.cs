namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes accessories model.
    /// </summary>
    public class BracingModel : ExtendedBaseEntity
    {
        #region NavigationProperties
        public virtual ICollection<CurtainsModel> Curtains { get; }
        #endregion
    }
}
