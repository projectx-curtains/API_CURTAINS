namespace Curtains.Domain.Models
{
    public class DesignModel : ExtendedByTitleBaseEntity
    {
        #region PropertiesRegion
        public bool Presence { get; set; }
        #endregion
        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents list of fabrics of that design.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; }
        #endregion
    }
}
