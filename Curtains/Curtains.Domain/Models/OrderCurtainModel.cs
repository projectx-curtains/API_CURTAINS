using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class OrderCurtainModel
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? CurtainsId { get; set; }

        public virtual CurtainModel? Curtains { get; set; }
        public virtual OrderModel? Order { get; set; }
    }
}
