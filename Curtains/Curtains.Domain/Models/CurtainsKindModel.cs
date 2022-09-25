using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class CurtainsKindModel
    {
        public CurtainsKindModel()
        {
            Curtains = new HashSet<CurtainsModel>();
        }
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
    }
}
