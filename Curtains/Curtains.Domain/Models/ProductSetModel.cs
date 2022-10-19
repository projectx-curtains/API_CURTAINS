using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes model of set of products.
    /// </summary>
    public class ProductSetModel : BaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = string.Empty;
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
        ///  This property represents price of product set.
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents curtains in that product set.
        /// </summary>
        public virtual CurtainsModel Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows in that product set.
        /// </summary>
        public virtual PillowsModel Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads in that product set.
        /// </summary>
        public virtual BedspreadsModel Bedspreads { get; set; }
        #endregion
    }
}
