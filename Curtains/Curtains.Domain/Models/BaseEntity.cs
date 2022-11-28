namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes base entity, which properties will be inherited by other entities.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        ///  This property represents unique identifier for entities.
        /// </summary>
        public int Id { get; set; }
    }
}
