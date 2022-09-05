using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class UserModel
    {
        public UserModel()
        {
            Orders = new HashSet<OrderModel>();
        }

        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public virtual UserOrderModel IdNavigation { get; set; } = null!;
        public virtual RoleModel Role { get; set; } = null!;
        public virtual ICollection<OrderModel> Orders { get; set; }
    }
}
