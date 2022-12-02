namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes extended by title entity, which properties will be inherited by other entities.
    /// </summary>
    public abstract class ExtendedByTitleBaseEntity : BaseEntity
    {
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; }
    }
}
