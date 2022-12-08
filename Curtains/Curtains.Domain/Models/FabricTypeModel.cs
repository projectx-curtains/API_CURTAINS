namespace Curtains.Domain.Models
{
    public class FabricTypeModel : ExtendedByTitleBaseEntity
    {
        /// <summary>
        ///  This property represents list of fabrics with that type.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; }
    }
}
