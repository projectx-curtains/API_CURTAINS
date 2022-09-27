using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class PillowsModel : BaseEntity
    {
        public PillowsModel()
        {
            Sets = new HashSet<ProductSetModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }
        #region PropertiesRegion

        public int FabricId { get; set; }
        public string Size { get; set; } = null!;
        public string Filler { get; set; } = null!;
        public bool RemovableCover { get; set; }
        public decimal Price { get; set; }
        public string Shape { get; set; } = null!;
        public virtual FabricModel Fabric { get; set; } = null!;
        public virtual MarketingInfoModel MarketingInfo { get; set; }
        public virtual ICollection<ProductSetModel> Sets { get; set; }
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion 


    }
}
