using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class ModelModel
    {
        public ModelModel()
        {
            Curtains = new HashSet<CurtainModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<CurtainModel> Curtains { get; set; }
    }
}
