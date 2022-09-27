using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class PaymentTypeModel : BaseEntity
    {
        public PaymentTypeModel()
        {
            Orders = new HashSet<OrderModel>();
        }

        #region NavigationPropertiesRegion
        public virtual ICollection<OrderModel> Orders { get; set; }
        #endregion
    }
}
