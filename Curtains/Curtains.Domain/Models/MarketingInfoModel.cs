using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class MarketingInfoModel : BaseEntity
    {
        public bool IsNew { get; set; }
        public bool IsOnSale { get; set; }
        public virtual CurtainsModel Curtains { get; set; } = null!;
        public virtual PillowsModel Pillows { get; set; } = null!;
        public virtual BedspreadsModel Bedspreads { get; set; } = null!;
        public virtual SetModel Sets { get; set; } = null!;

    }
}
