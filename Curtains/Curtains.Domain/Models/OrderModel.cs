using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class OrderModel
    {
        public OrderModel()
        {
            OrderCurtains = new HashSet<OrderCurtainModel>();
        }

        public int Id { get; set; }
        public string CustomerType { get; set; } = null!;
        public string PaymentType { get; set; } = null!;
        public int UserId { get; set; }
        public int DeliveryTypeId { get; set; }
        public string? Comment { get; set; }
        public string Status { get; set; } = null!;

        public virtual DeliveryTypeModel DeliveryType { get; set; } = null!;
        public virtual UserModel User { get; set; } = null!;
        public virtual UserOrderModel UserOrder { get; set; } = null!;
        public virtual ICollection<OrderCurtainModel> OrderCurtains { get; set; }
    }
}
