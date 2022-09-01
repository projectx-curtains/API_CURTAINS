using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class Color
    {
        public Color()
        {
            Fabrics = new HashSet<Fabric>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Code { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Fabric> Fabrics { get; set; }
    }
}
