using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> FabricDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class FabricDTO
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
        ///  This property represents situation, if fabric is dense or not.
        /// </summary>
        public bool Density { get; set; }
        /// <summary>
        ///  This property represents price of fabric.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents length of fabric.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///  This property represents wifth of fabric.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents situation, if there is design on fabric or not.
        /// </summary>
        public bool Design { get; set; }
        /// <summary>
        ///  This property represents consistency of fabric.
        /// </summary>
        public virtual ConsistencyDTO Consistency { get; set; }
        /// <summary>
        ///  This property represents color of fabric.
        /// </summary>
        public virtual ColorDTO Color { get; set; }
        /// <summary>
        ///  This property represents decorations of fabric.
        /// </summary>
        public DecorationsDTO Decorations { get; set; }
        /// <summary>
        ///  This property represents manufacturer of fabric.
        /// </summary>
        public ManufacturerDTO Manufacturer { get; set; }
        #endregion
    }
}