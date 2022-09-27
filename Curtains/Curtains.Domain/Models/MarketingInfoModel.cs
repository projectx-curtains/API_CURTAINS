using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class MarketingInfoModel : BaseEntity
    {
        #region PropertiesRegion

        public bool IsNew { get; set; }
        public bool IsOnSale { get; set; }
        public virtual CurtainsModel Curtains { get; set; } 
        public virtual PillowsModel Pillows { get; set; } 
        public virtual BedspreadsModel Bedspreads { get; set; }
        public virtual ProductSetModel Sets { get; set; }
        #endregion

    }
}
