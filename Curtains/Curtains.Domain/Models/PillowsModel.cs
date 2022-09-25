using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class PillowsModel
    {
        public PillowsModel()
        {
            Sets = new HashSet<SetModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public int FabricId { get; set; }
        public string Size { get; set; } = null!;
        public string Filler { get; set; } = null!;
        public bool RemovableCover { get; set; }
        public decimal Price { get; set; }
        public string Shape { get; set; } = null!;
        public virtual FabricModel Fabric { get; set; } = null!;
        public virtual MarketingInfoModel MarketingInfo { get; set; }
        public virtual ICollection<SetModel> Sets { get; set; }
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }

    }
}
