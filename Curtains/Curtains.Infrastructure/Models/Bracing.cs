using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class Bracing
    {
        public Bracing()
        {
            Curtains = new HashSet<Curtain>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Curtain> Curtains { get; set; }
    }
}
