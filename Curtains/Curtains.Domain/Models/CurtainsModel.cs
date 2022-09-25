using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class CurtainsModel
    {
        public CurtainsModel()
        {
            Sets = new HashSet<SetModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }

        public int Id { get; set; }
        public bool Density { get; set; }
        public bool SunProtection { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int FabricId { get; set; }
        public int MaterialId { get; set; }
        public int AccessoriesId { get; set; }
        public int CurtainsTypeId { get; set; }
        public int CurtainsKindId { get; set; }
        public decimal Price { get; set; }
        public string Purpose { get; set; }
        public virtual FabricModel Fabric { get; set; } = null!;
        public virtual MaterialModel Material { get; set; } = null!;
        public virtual AccessoriesModel Accessories { get; set; } = null!;
        public virtual CurtainsTypeModel CurtainsType { get; set; } = null!;
        public virtual CurtainsKindModel CurtainsKind { get; set; } = null!;
        public virtual MarketingInfoModel MarketingInfo { get; set; } = null!;
        public virtual ICollection<SetModel> Sets { get; set; }
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
    }
}
