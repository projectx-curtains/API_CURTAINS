using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes bedspreads model.
    /// </summary>
    public class BedspreadsModel : ExtendedBaseEntity
    {
        public BedspreadsModel()
        {
            Sets = new HashSet<ProductSetModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents size of bedspreads.
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        ///  This property represents purpose of bedspreads.
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        ///  This property represents price of bedspreads.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents length of bedspreads.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///  This property represents width of bedspreads.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents shape of bedspreads.
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        ///  This property represents FabricId column.
        /// </summary>
        public int FabricId { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents fabric of bedspreads.
        /// </summary>
        public virtual FabricModel Fabric { get; set; }
        /// <summary>
        ///  This property represents list of product sets, in which there are bedspreads.
        /// </summary>
        public virtual ICollection<ProductSetModel> Sets { get; set; }
        /// <summary>
        ///  This property represents list of UserOrders, in which there are bedspreads.
        /// </summary>
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion
    }
}
