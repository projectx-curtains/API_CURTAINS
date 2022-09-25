using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class AccessoriesModel
    {
        public AccessoriesModel()
        {
            Curtains = new HashSet<CurtainsModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public int ColorId { get; set; }
        public decimal Price { get; set; }
        public virtual ColorModel Color { get; set; } = null!;
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
    }
}
