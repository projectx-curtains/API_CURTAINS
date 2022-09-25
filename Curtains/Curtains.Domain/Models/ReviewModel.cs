using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    internal class ReviewModel
    {
        public int Id { get; set; }
        public string PersonName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Review { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
