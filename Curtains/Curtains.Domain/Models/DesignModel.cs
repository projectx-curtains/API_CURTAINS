namespace Curtains.Domain.Models
{
    public class DesignModel : ExtendedByTitleBaseEntity
    {
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of fabrics of that design.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; set; } = new List<FabricModel>();
        #endregion
    }
}
