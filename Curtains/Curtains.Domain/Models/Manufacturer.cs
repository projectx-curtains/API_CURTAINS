using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Curtains = new HashSet<Curtain>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? Website { get; set; }

        public virtual ICollection<Curtain> Curtains { get; set; }
    }
}
