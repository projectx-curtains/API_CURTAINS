using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class BedspreadsModel : BaseEntity
    {
        public BedspreadsModel()
        {
            Sets = new HashSet<ProductSetModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }
        #region PropertiesRegion
        public string Size { get; set; } = null!;
        public string Purpose { get; set; }
        public decimal Price { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public string Shape { get; set; } = null!;
        public int FabricId { get; set; }
        public MarketingInfoModel MarketingInfo { get; set; }
        public virtual FabricModel Fabric { get; set; } = null!;
        public virtual ICollection<ProductSetModel> Sets { get; set; }
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion
    }
}
