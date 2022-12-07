namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes manufacturer model.
    /// </summary>
    public class ManufacturerModel : BaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents country of manufacturer.
        /// </summary>
        public string Country { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of fabrics with that manufacturer.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; }
        #endregion
    }
}
