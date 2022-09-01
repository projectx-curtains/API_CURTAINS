using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class DeliveryType
    {
        public DeliveryType()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
