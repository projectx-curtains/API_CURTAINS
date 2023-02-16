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
    public class AccessoriesDTO : BaseDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents the furniture of accessories.
        /// </summary>
        public FurnitureDTO Furniture { get; set;}
        /// <summary>
        ///  This property represents the bracing of accessories.
        /// </summary>
        public BracingDTO Bracing { get; set;}
        /// <summary>
        ///  This property represents the color group of accessories.
        /// </summary>
        public ColorGroupDTO ColorGroup { get; set;}
        /// <summary>
        ///  This property represents the manufacturer of accessories.
        /// </summary>
        public ManufacturerDTO Manufacturer { get; set;}
        #endregion
    }
}