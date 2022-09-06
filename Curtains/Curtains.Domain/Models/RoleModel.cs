using System;
using System.Collections.Generic;

namespace Curtains.Domain.Models
{
    public partial class RoleModel
    {
        public RoleModel()
        {
            Users = new HashSet<UserModel>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<UserModel> Users { get; set; }
    }
}
