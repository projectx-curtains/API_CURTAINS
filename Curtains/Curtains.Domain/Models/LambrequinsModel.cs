using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class LambrequinsModel : BaseEntity
    {
        public LambrequinsModel()
        {
            UserOrders = new HashSet<UserOrderModel>();
        }
        #region PropertiesRegion

        public int ColorId { get; set; }
        public decimal Price { get; set; }
        public virtual ColorModel Color { get; set; } = null!;
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion
    }
}
