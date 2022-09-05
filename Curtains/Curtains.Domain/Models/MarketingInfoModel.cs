using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class MarketingInfoModel
    {
        public int Id { get; set; }
        public bool IsNew { get; set; }
        public bool IsOnSale { get; set; }
        public bool? IsInStock { get; set; }

        public virtual CurtainModel IdNavigation { get; set; } = null!;
    }
}
