using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class Fabric
    {
        public Fabric()
        {
            Curtains = new HashSet<Curtain>();
        }

        public int Id { get; set; }
        public bool LightTransmittance { get; set; }
        public string? Description { get; set; }
        public int? MaterialId { get; set; }
        public int? ColorId { get; set; }
        public int? DecorationId { get; set; }
        public decimal Price { get; set; }

        public virtual Color? Color { get; set; }
        public virtual Decoration? Decoration { get; set; }
        public virtual Material? Material { get; set; }
        public virtual ICollection<Curtain> Curtains { get; set; }
    }
}
