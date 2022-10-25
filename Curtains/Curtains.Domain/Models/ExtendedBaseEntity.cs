using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <summary>
        ///  This property represents description of entities.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}