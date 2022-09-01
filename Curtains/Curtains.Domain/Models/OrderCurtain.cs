using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class OrderCurtain
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? CurtainsId { get; set; }

        public virtual Curtain? Curtains { get; set; }
        public virtual Order? Order { get; set; }
    }
}
