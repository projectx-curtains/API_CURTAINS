using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class FabricModel
    {
        public FabricModel()
        {
            Curtains = new HashSet<CurtainModel>();
        }

        public int Id { get; set; }
        public bool LightTransmittance { get; set; }
        public string? Description { get; set; }
        public int? MaterialId { get; set; }
        public int? ColorId { get; set; }
        public int? DecorationId { get; set; }
        public decimal Price { get; set; }

        public virtual ColorModel? Color { get; set; }
        public virtual DecorationModel? Decoration { get; set; }
        public virtual MaterialModel? Material { get; set; }
        public virtual ICollection<CurtainModel> Curtains { get; set; }
    }
}
