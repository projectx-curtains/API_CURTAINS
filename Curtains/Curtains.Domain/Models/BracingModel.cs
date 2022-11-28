namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes accessories model.
    /// </summary>
    public class BracingModel : ExtendedBaseEntity
    {
        #region NavigationProperties
        public virtual ICollection<CurtainModel> Curtains { get; } = new List<CurtainModel>();

        public virtual ICollection<LambrequinsModel> Lambrequins { get; } = new List<LambrequinsModel>();
        #endregion
    }
}
