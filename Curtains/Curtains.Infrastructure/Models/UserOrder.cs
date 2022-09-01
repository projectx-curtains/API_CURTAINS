using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class UserOrder
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Cost { get; set; }

        public virtual Order IdNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
