using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> ManufacturerDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class ManufacturerDTO
    {
        #region PropertiesRegion
        /// <summary>
        /// This property represents unique identifier for data tranfer objects.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  This property represents country of manufacturer.
        /// </summary>
        public string Country { get; set; }
        #endregion
    }
}