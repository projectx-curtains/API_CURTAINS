using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    internal class DeliveryTypeModel
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
