using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class DecorationsModel : BaseEntity
    {
        public DecorationsModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }

        public string Title { get; set; }
        public bool Presence { get; set; }
        public string Description { get; set; }

        public virtual ICollection<FabricModel> Fabrics { get; set; }
    }
}
