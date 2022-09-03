using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class DeliveryTypeModel
    {
        public DeliveryTypeModel()
        {
            Orders = new HashSet<OrderModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }

        public virtual ICollection<OrderModel> Orders { get; set; }
    }
}
