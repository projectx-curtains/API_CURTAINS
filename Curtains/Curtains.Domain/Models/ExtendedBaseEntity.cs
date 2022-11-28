namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes extended entity, which properties will be inherited by other entities.
    /// </summary>
    public abstract class ExtendedBaseEntity : ExtendedByTitleBaseEntity
    {
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
