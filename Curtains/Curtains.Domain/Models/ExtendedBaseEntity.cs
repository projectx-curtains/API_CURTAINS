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
    public abstract class ExtendedBaseEntity : ExtendedByTitleBaseEntity
    {
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string? Description { get; set; }
    }
}
