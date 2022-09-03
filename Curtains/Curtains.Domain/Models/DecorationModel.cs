using System;
using System.Collections.Generic;

namespace Curtains.Infrastructure.Models
{
    public partial class DecorationModel
    {
        public DecorationModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public bool Presence { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<FabricModel> Fabrics { get; set; }
    }
}
