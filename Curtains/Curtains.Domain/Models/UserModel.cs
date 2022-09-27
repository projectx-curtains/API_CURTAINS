using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class UserModel : BaseEntity
    {
        public UserModel()
        {
            Orders = new HashSet<OrderModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }
        #region PropertiesRegion

        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int? Flat { get; set; }
        public int? PostOffice { get; set; }

        public virtual ICollection<UserOrderModel> UserOrders { get; set; } = null!;
        public virtual ICollection<OrderModel> Orders { get; set; }
        #endregion
    }
}
