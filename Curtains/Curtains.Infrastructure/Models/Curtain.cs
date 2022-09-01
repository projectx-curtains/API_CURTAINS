using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class Curtain
    {
        public Curtain()
        {
            OrderCurtains = new HashSet<OrderCurtain>();
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

        public virtual Bracing? Bracing { get; set; }
        public virtual Fabric? Fabric { get; set; }
        public virtual Manufacturer? Manufacturer { get; set; }
        public virtual Model? Model { get; set; }
        public virtual MarketingInfo MarketingInfo { get; set; } = null!;
        public virtual ICollection<OrderCurtain> OrderCurtains { get; set; }
    }
}
