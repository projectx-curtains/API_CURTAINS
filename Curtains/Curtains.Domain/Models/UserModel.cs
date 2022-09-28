using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes user model.
    /// </summary>
    public class UserModel : BaseEntity
    {
        public UserModel()
        {
            Orders = new HashSet<OrderModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents name of user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  This property represents email of user.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        ///  This property represents phone number of user.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        ///  This property represents country of user.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        ///  This property represents city of user.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        ///  This property represents street of user.
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        ///  This property represents house number of user.
        /// </summary>
        public string House { get; set; }
        /// <summary>
        ///  This property represents flat number of user.
        /// </summary>
        public int? Flat { get; set; }
        /// <summary>
        ///  This property represents post office of user.
        /// </summary>
        public int? PostOffice { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents list of UserOrders, related to this user.
        /// </summary>
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        /// <summary>
        ///  This property represents list of orders of user.
        /// </summary>
        public virtual ICollection<OrderModel> Orders { get; set; }
        #endregion
    }
}
