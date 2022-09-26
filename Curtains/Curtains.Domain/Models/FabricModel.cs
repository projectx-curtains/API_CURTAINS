using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class FabricModel : BaseEntity
    {
        public FabricModel()
        {
            Curtains = new HashSet<CurtainsModel>();
            Bedspreads = new HashSet<BedspreadsModel>();
            Pillows = new HashSet<PillowsModel>();
        }

        public string Title { get; set; } = null!;
        public bool Density { get; set; }
        public string Description { get; set; }
        public int ConsistencyId { get; set; }
        public int ColorId { get; set; }
        public int DecorationId { get; set; }
        public int ManufacurerId { get; set; }
        public decimal Price { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public bool Design { get; set; }

        public virtual ConsistencyModel Consistency { get; set; } = null!;
        public virtual ColorModel Color { get; set; } = null!;
        public virtual DecorationsModel Decoration { get; set; } = null!; 
        public virtual ManufacturerModel Manufacturer { get; set; } = null!;
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        public virtual ICollection<BedspreadsModel> Bedspreads { get; set; }
        public virtual ICollection<PillowsModel> Pillows { get; set; }

    }
}
