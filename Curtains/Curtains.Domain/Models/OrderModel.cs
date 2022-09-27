using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class OrderModel : BaseEntity
    {
        public OrderModel()
        {
        }

        #region PropertiesRegion
        public int UserId { get; set; }
        public int PaymentTypeId { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Comment { get; set; }
        #endregion

        #region NavigationProperties
        public virtual DeliveryTypeModel DeliveryType { get; set; }  
        public virtual UserModel User { get; set; }  
        public virtual PaymentTypeModel PaymentType { get; set; }  
        public virtual UserOrderModel UserOrder { get; set; }  
        #endregion
    }
}
