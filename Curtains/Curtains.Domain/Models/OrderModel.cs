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
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents UserId column.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        ///  This property represents PaymentTypeId column.
        /// </summary>
        public int PaymentTypeId { get; set; }
        /// <summary>
        ///  This property represents DeliveryTypeId column.
        /// </summary>
        public int DeliveryTypeId { get; set; }
        /// <summary>
        ///  This property represents comment to order.
        /// </summary>
        public string Comment { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents delivery type of order.
        /// </summary>
        public virtual DeliveryTypeModel DeliveryType { get; set; }
        /// <summary>
        ///  This property represents user, who made order.
        /// </summary>
        public virtual UserModel User { get; set; }
        /// <summary>
        ///  This property represents payment type of order.
        /// </summary>
        public virtual PaymentTypeModel PaymentType { get; set; }
        /// <summary>
        ///  This property represents UserOrder.
        /// </summary>
        public virtual UserOrderModel UserOrder { get; set; }  
        #endregion
    }
}
