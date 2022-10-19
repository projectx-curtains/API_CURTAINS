using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes lambrequins model.
    /// </summary>
    public class LambrequinsModel : BaseEntity
    {
        public LambrequinsModel()
        {
            UserOrders = new HashSet<UserOrderModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents title of entities.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        ///  This property represents ColorId column.
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        ///  This property represents price of lambrequins.
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents color of lambrequins.
        /// </summary>
        public virtual ColorModel Color { get; set; }
        /// <summary>
        ///  This property represents list of UserOrders with that lambrequins.
        /// </summary>
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion
    }
}
