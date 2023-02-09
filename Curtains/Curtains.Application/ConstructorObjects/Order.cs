using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class Order
    {
        /// <summary>
        ///  This property represents comment to order.
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// User phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Numbers of existing products ordered by the user
        /// </summary>
        public virtual IEnumerable<IProduct> Products { get; set; }
    }
}