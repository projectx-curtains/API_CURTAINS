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
    public class ProductSetDTO
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
        ///  This property represents price of product set.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents curtains in that product set.
        /// </summary>
        public CurtainsDTO Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows in that product set.
        /// </summary>
        public PillowsDTO Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads in that product set.
        /// </summary>
        public BedspreadsDTO Bedspreads { get; set; }
        #endregion
    }
}