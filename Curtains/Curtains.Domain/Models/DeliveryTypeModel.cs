using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes delivery type model.
    /// </summary>
    public class DeliveryTypeModel : BaseEntity
    {
        public DeliveryTypeModel()
        {
            Orders = new HashSet<OrderModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        ///  This property represents price of delivery.
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of orders with that type of delivery.
        /// </summary>
        public virtual ICollection<OrderModel> Orders { get; set; }
        #endregion
    }
}
