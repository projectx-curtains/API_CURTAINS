using Curtains.Domain.Models;
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
    public class FabricDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
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
        public DesignDTO Design { get; set; }
        /// <summary>
        ///  This property represents consistency of fabric.
        /// </summary>
        public ConsistencyDTO Consistency { get; set; }
        /// <summary>
        ///  This property represents color of fabric.
        /// </summary>
        public ColorDTO Color { get; set; }
        /// <summary>
        ///  This property represents decorations of fabric.
        /// </summary>
        public DecorationsDTO Decorations { get; set; }
        /// <summary>
        ///  This property represents kind of fabric.
        /// </summary>
        public virtual FabricKindDTO FabricKind { get; set; }
        /// <summary>
        ///  This property represents type of fabric.
        /// </summary>
        public virtual FabricTypeDTO FabricType { get; set; }
        /// <summary>
        ///  This property represents material of fabric.
        /// </summary>
        public virtual MaterialDTO Material { get; set; }
        /// <summary>
        ///  This property represents manufacturer of fabric.
        /// </summary>
        public ManufacturerDTO Manufacturer { get; set; }
        #endregion
    }
}