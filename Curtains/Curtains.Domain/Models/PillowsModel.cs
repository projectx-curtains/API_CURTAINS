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
        public string Size { get; set; }  
        public string Filler { get; set; }  
        public bool RemovableCover { get; set; }
        public decimal Price { get; set; }
        public string Shape { get; set; }
        #endregion

        #region NavigationProperties
        public virtual FabricModel Fabric { get; set; }  
        public virtual MarketingInfoModel MarketingInfo { get; set; }
        public virtual ICollection<ProductSetModel> Sets { get; set; }
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion 
    }
}
