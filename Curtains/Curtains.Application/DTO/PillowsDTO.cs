using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curtains.Application.DTO.Interfaces;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> PillowsDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class PillowsDTO : BaseExtendedDTO, IPillowsDto
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents size of pillows.
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        ///  This property represents filler of pillows.
        /// </summary>
        public string Filler { get; set; }
        /// <summary>
        ///  This property represents situation, if cover of pillows is removable.
        /// </summary>
        public bool RemovableCover { get; set; }
        /// <summary>
        ///  This property represents price of pillows.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents shape of pillows.
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        ///  This property represents fabric of pillows.
        /// </summary>
        public FabricDTO Fabric { get; set; }
        #endregion
    }
}