﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    internal class ConsistencyModel
    {
        public ConsistencyModel()
        {
            Fabrics = new HashSet<FabricModel>();
        }
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public virtual ICollection<FabricModel> Fabrics { get; set; }

    }
}
