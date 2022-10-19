namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes accessories model.
    /// </summary>
    public class AccessoriesModel : ExtendedBaseEntity
    {
        public AccessoriesModel()
        {
            Curtains = new HashSet<CurtainsModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents the ColorId column.
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        ///  This property represents price of accessories.
        /// </summary>
        public decimal Price { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents color of accessories.
        /// </summary>
        public virtual ColorModel Color { get; set; }
        /// <summary>
        ///  This property represents list of UserOrders in which there are accessoreis.
        /// </summary>
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        /// <summary>
        ///  This property represents list of curtains in which there are accessories.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        #endregion
    }
}
