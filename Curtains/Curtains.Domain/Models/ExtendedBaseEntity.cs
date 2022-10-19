namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes extended entity, which properties will be inherited by other entities.
    /// </summary>
    public abstract class ExtendedBaseEntity : BaseEntity
    {
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = string.Empty;
    }
}
