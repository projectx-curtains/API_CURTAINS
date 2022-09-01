using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class MarketingInfo
    {
        public int Id { get; set; }
        public bool IsNew { get; set; }
        public bool IsOnSale { get; set; }
        public bool? IsInStock { get; set; }

        public virtual Curtain IdNavigation { get; set; } = null!;
    }
}
