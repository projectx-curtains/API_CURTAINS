using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class UserOrderModel
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Cost { get; set; }

        public virtual OrderModel IdNavigation { get; set; } = null!;
        public virtual UserModel User { get; set; } = null!;
    }
}
