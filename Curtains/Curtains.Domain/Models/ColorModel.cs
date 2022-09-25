using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    internal class ColorModel
    {
        public ColorModel()
        {
            Fabrics = new HashSet<FabricModel>();
            Accessories = new HashSet<AccessoriesModel>();
            Lambrequins = new HashSet<LambrequinsModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public string Code { get; set; }

        public virtual ICollection<FabricModel> Fabrics { get; set; }
        public virtual ICollection<AccessoriesModel> Accessories { get; set; }
        public virtual ICollection<LambrequinsModel> Lambrequins { get; set; }
    }
}
