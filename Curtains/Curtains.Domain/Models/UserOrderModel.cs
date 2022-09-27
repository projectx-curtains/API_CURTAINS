using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class UserOrderModel : BaseEntity
    {
        #region PropertiesRegion
        public DateTime Date { get; set; }
        public decimal Cost { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public int? AccessoriesId { get; set; }
        public int? CurtainsId { get; set; }
        public int? PillowsId { get; set; }
        public int? BedspreadsId { get; set; }
        public int? SetId { get; set; }
        public int? LambrequinsId { get; set; }
        #endregion

        #region NavigationProperties
        public virtual UserModel User { get; set; }  
        public virtual OrderModel Order { get; set; }  
        public virtual AccessoriesModel Accessories { get; set; }
        public virtual CurtainsModel Curtains { get; set; }
        public virtual PillowsModel Pillows { get; set; }
        public virtual BedspreadsModel Bedspreads { get; set; }
        public virtual ProductSetModel Set { get; set; }
        public virtual LambrequinsModel Lambrequins { get; set; }
        #endregion
    }
}
