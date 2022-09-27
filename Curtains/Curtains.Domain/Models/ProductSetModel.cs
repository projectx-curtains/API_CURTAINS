using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ProductSetModel : BaseEntity
    {
        #region PropertiesRegion
        public int? CurtainsId { get; set; }
        public int? PillowsId { get; set; }
        public int? BedspreadsId { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        public virtual CurtainsModel Curtains { get; set; }
        public virtual PillowsModel Pillows { get; set; }
        public virtual BedspreadsModel Bedspreads { get; set; }
        #endregion
    }
}
