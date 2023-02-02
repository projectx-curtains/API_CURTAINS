namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes accessories model.
    /// </summary>
    public class BracingModel : ExtendedBaseEntity
    {
        #region NavigationProperties
        /// <summary>
        ///  This property represents accessories with that bracing.
        /// </summary>
        public virtual ICollection<AccessoriesModel> Accessories { get; }
        #endregion
    }
}
