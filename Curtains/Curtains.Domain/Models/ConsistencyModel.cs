namespace Curtains.Domain.Models
{
    public class ConsistencyModel : ExtendedBaseEntity
    {
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of fabrics with that consistency.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; } = new List<FabricModel>();
        #endregion

    }
}
