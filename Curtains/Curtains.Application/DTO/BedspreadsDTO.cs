using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> BedspreadsDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class BedspreadsDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents size of bedspreads.
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        ///  This property represents purpose of bedspreads.
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        ///  This property represents price of bedspreads.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents length of bedspreads.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///  This property represents width of bedspreads.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents shape of bedspreads.
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        ///  This property represents fabric of bedspreads.
        /// </summary>
        public FabricDTO Fabric { get; set; }
        #endregion
    }
}