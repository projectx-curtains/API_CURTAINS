using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> AccessoriesDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class AccessoriesDTO
    {
        #region PropertiesRegion
        /// <summary>
        /// This property represents unique identifier for data tranfer objects.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This property represents title for data tranfer objects.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// This property represents description for data tranfer objects.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        ///  This property represents price of accessories.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents color of accessories.
        /// </summary>
        public ColorDTO Color { get; set; }
        #endregion
    }
}
