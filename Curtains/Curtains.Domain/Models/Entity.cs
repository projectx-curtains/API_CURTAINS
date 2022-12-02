using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Curtains.Domain.Models
{
    /// <summary>
    /// Class<c> Entity</c> describes entity interaction model for database
    /// </summary>
    public abstract class Entity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents unique identifier for entities.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///  This property represents creation date and time of entity.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        ///  This property represents date and time of last modification.
        /// </summary>
        public DateTimeOffset ModifiedDate { get; set; }

        /// <summary>
        ///  This property represents, who created entity.
        /// </summary>
        public string CreatedBy { get; set; } = null!;

        /// <summary>
        ///  This property represents, who modified entity.
        /// </summary>
        public string ModifiedBy { get; set; } = null!;

        /// <summary>
        ///  This property represents situation, if entity is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        ///  This property represents situation, if entity is new.
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        ///  This property represents situation, if entity is modified.
        /// </summary>
        public bool IsModified { get; set; }

        /// <summary>
        ///  This property represents state of the entity.
        /// </summary>
        public EntityState State { get; set; }
        #endregion
    }
}
