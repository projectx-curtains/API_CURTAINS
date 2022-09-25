using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    internal class OurWorksModel
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;

    }
}
