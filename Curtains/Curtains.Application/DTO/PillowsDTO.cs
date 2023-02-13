using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> PillowsDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class PillowsDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents FabricId column.
        /// </summary>
        public int? FabricId { get; set; }
        /// <summary>
        ///  This property represents size of pillows.
        /// </summary>
        public int? SizeId { get; set; }
        /// <summary>
        ///  This property represents price of pillows.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents Design id column.
        /// </summary>
        public int? DesignId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents design of pullow.
        /// </summary>
        public DesignDTO Design { get; set; }
        /// <summary>
        ///  This property represents fabric of pillows.
        /// </summary>
        public FabricDTO Fabric { get; set; }
        /// <summary>
        ///  This property represents size of pillows.
        /// </summary>
        public PillowsSizeDTO Size { get; set; }
        #endregion
    }
}