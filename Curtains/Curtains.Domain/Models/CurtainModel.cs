using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class CurtainModel
    {
        public CurtainModel()
        {
            OrderCurtains = new HashSet<OrderCurtainModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int? FabricId { get; set; }
        public int? BracingId { get; set; }
        public int? ModelId { get; set; }
        public int? ManufacturerId { get; set; }
        public decimal Price { get; set; }

        public virtual BracingModel? Bracing { get; set; }
        public virtual FabricModel? Fabric { get; set; }
        public virtual ManufacturerModel? Manufacturer { get; set; }
        public virtual ModelModel? Model { get; set; }
        public virtual MarketingInfoModel MarketingInfo { get; set; } = null!;
        public virtual ICollection<OrderCurtainModel> OrderCurtains { get; set; }
    }
}
