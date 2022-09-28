using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes model of relationship between User and Order tables.
    /// </summary>
    public class UserOrderModel : BaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents date of order.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        ///  This property represents cost of order.
        /// </summary>
        public decimal Cost { get; set; }
        /// <summary>
        ///  This property represents UserId column.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        ///  This property represents OrderId column.
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        ///  This property represents AccessoriesId column.
        /// </summary>
        public int? AccessoriesId { get; set; }
        /// <summary>
        ///  This property represents CurtainsId column.
        /// </summary>
        public int? CurtainsId { get; set; }
        /// <summary>
        ///  This property represents PillowsId column.
        /// </summary>
        public int? PillowsId { get; set; }
        /// <summary>
        ///  This property represents BedspreadsId column.
        /// </summary>
        public int? BedspreadsId { get; set; }
        /// <summary>
        ///  This property represents SetId column.
        /// </summary>
        public int? SetId { get; set; }
        /// <summary>
        ///  This property represents LambrequinsId column.
        /// </summary>
        public int? LambrequinsId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents user, who made this order.
        /// </summary>
        public virtual UserModel User { get; set; }
        /// <summary>
        ///  This property represents order in this UserOrder.
        /// </summary>
        public virtual OrderModel Order { get; set; }
        /// <summary>
        ///  This property represents accessories in order.
        /// </summary>
        public virtual AccessoriesModel Accessories { get; set; }
        /// <summary>
        ///  This property represents curtains in order.
        /// </summary>
        public virtual CurtainsModel Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows in order.
        /// </summary>
        public virtual PillowsModel Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads in order.
        /// </summary>
        public virtual BedspreadsModel Bedspreads { get; set; }
        /// <summary>
        ///  This property represents product set in order.
        /// </summary>
        public virtual ProductSetModel Set { get; set; }
        /// <summary>
        ///  This property represents lambrequins in order.
        /// </summary>
        public virtual LambrequinsModel Lambrequins { get; set; }
        #endregion
    }
}
