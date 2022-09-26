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

        public int UserId { get; set; }
        public int PaymentTypeId { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Comment { get; set; } = null!;

        public virtual DeliveryTypeModel DeliveryType { get; set; } = null!;
        public virtual UserModel User { get; set; } = null!;
        public virtual PaymentTypeModel PaymentType { get; set; } = null!;

        public virtual UserOrderModel UserOrder { get; set; } = null!;
    }
}
