using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> CurtainsDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class CurtainsDTO : BaseExtendedDTO
    {
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
        ///  This property represents price of curtains.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents purpose of curtains.
        /// </summary>
        public string Purpose { get; set; }
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
        ///  This property represents fabric of curtains.
        /// </summary>
        public FabricDTO Fabric { get; set; }
        /// <summary>
        ///  This property represents material of curtains.
        /// </summary>
        public MaterialDTO Material { get; set; }
        /// <summary>
        ///  This property represents accessories of curtains.
        /// </summary>
        public AccessoriesDTO Accessories { get; set; }
        /// <summary>
        ///  This property represents type of curtains.
        /// </summary>
        public CurtainsTypeDTO CurtainsType { get; set; }
        /// <summary>
        ///  This property represents kind of curtains.
        /// </summary>
        public CurtainsKindDTO CurtainsKind { get; set; }
        #endregion
    }
}