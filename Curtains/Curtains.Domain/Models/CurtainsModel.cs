using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class CurtainsModel : ExtendedBaseEntity
    {
        /// <summary>
        ///  This class describes curtains model.
        /// </summary>
        public CurtainsModel()
        {
            Sets = new HashSet<ProductSetModel>();
            UserOrders = new HashSet<UserOrderModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if curtains are dense or not.
        /// </summary>
        public bool Density { get; set; }
        /// <summary>
        ///  This property represents situation, if curtains are sun-protected or not.
        /// </summary>
        public bool SunProtection { get; set; }
        /// <summary>
        ///  This property represents height of curtains.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        ///  This property represents width of curtains.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents FabricId column.
        /// </summary>
        public int FabricId { get; set; }
        /// <summary>
        ///  This property represents MaterialId column.
        /// </summary>
        public int MaterialId { get; set; }
        /// <summary>
        ///  This property represents AccessoriesId column.
        /// </summary>
        public int AccessoriesId { get; set; }
        /// <summary>
        ///  This property represents CurtainsTypeId column.
        /// </summary>
        public int CurtainsTypeId { get; set; }
        /// <summary>
        ///  This property represents CurtainsKindId column.
        /// </summary>
        public int CurtainsKindId { get; set; }
        /// <summary>
        ///  This property represents price of curtains.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents purpose of curtains.
        /// </summary>
        public string Purpose { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents fabric of curtains.
        /// </summary>
        public virtual FabricModel Fabric { get; set; }
        /// <summary>
        ///  This property represents material of curtains.
        /// </summary>
        public virtual MaterialModel Material { get; set; }
        /// <summary>
        ///  This property represents accessories of curtains.
        /// </summary>
        public virtual AccessoriesModel Accessories { get; set; }
        /// <summary>
        ///  This property represents type of curtains.
        /// </summary>
        public virtual CurtainsTypeModel CurtainsType { get; set; }
        /// <summary>
        ///  This property represents kind of curtains.
        /// </summary>
        public virtual CurtainsKindModel CurtainsKind { get; set; }
        /// <summary>
        ///  This property represents sets with that curtains curtains.
        /// </summary>
        public virtual ICollection<ProductSetModel> Sets { get; set; }
        /// <summary>
        ///  This property represents list of UserOrders with that curtains.
        /// </summary>
        public virtual ICollection<UserOrderModel> UserOrders { get; set; }
        #endregion
    }
}
