using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderCurtains = new HashSet<OrderCurtain>();
        }

        public int Id { get; set; }
        public string CustomerType { get; set; } = null!;
        public string PaymentType { get; set; } = null!;
        public int UserId { get; set; }
        public int DeliveryTypeId { get; set; }
        public string? Comment { get; set; }
        public string Status { get; set; } = null!;

        public virtual DeliveryType DeliveryType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual UserOrder UserOrder { get; set; } = null!;
        public virtual ICollection<OrderCurtain> OrderCurtains { get; set; }
    }
}
