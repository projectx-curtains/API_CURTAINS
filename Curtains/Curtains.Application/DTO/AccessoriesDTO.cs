using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curtains.Application.DTO.Interfaces;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> AccessoriesDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class AccessoriesDTO : BaseExtendedDTO, IAccessoriesDto
    {
        #region PropertiesRegion
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