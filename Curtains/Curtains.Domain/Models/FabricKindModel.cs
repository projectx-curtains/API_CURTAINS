namespace Curtains.Domain.Models
{
    public class FabricKindModel : ExtendedByTitleBaseEntity
    {
        /// <summary>
        ///  This property represents list of fabrics with that kind.
        /// </summary>
        public virtual ICollection<FabricModel> Fabrics { get; } = new List<FabricModel>();
        /// <summary>
        ///  This property represents list of lambrequins with that kind.
        /// </summary>
        public virtual ICollection<LambrequinsModel> Lambrequins { get; } = new List<LambrequinsModel>();
    }
}
