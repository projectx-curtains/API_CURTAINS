using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class DeliveryTypeModel : BaseEntity
    {
        public DeliveryTypeModel()
        {
            Orders = new HashSet<OrderModel>();
        }

        #region PropertiesRegion
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        public virtual ICollection<OrderModel> Orders { get; set; }
        #endregion
    }
}
