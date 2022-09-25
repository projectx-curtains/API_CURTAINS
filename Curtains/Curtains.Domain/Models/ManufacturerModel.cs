using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    internal class ManufacturerModel
    {
        public ManufacturerModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        public int Id { get; set; }
        public string Country { get; set; } = null!;

        public virtual ICollection<FabricModel> Fabrics { get; set; }
    }
}
