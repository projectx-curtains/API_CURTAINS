using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes order model.
    /// </summary>
    public class OrderModel : BaseEntity
    {
        public OrderModel()
        {
            MarketingInfos = new HashSet<MarketingInfoModel>();
        }

        #region PropertiesRegion
        /// <summary>
        /// This property represents comment to order.
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Phone number of user.
        /// </summary>
        public string PhoneNumber { get; set; }
        #endregion

        #region NavigationProperties
        ICollection<MarketingInfoModel> MarketingInfos { get; set; }
        #endregion
    }
}
