using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes payment type model.
    /// </summary>
    public class PaymentTypeModel : BaseEntity
    {
        public PaymentTypeModel()
        {
            Orders = new HashSet<OrderModel>();
        }

        #region NavigationPropertiesRegion
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        ///  This property represents list of orders with that payment type.
        /// </summary>
        public virtual ICollection<OrderModel> Orders { get; set; }
        #endregion
    }
}
