using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> ProductSetDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class ProductSetDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents CurtainsId column.
        /// </summary>
        public int? CurtainsId { get; set; }
        /// <summary>
        ///  This property represents PillowsId column.
        /// </summary>
        public int? PillowsId { get; set; }
        /// <summary>
        ///  This property represents BedspreadsId column.
        /// </summary>
        public int? BedspreadsId { get; set; }
        /// <summary>
        ///  This property represents LabmvrequinsId column.
        /// </summary>
        public int? LambrequinsId { get; set; }
        /// <summary>
        ///  This property represents price of product set.
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents curtains in that product set.
        /// </summary>
        public CurtainsDTO? Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows in that product set.
        /// </summary>
        public PillowsDTO? Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads in that product set.
        /// </summary>
        public BedspreadsDTO? Bedspreads { get; set; }
        /// <summary>
        ///  This property represents lambrequin in that set.
        /// </summary>
        public LambrequinsDTO? Lambrequins { get; set; }
        #endregion
    }
}