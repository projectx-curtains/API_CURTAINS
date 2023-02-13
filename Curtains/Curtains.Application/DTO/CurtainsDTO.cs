using System.Security.AccessControl;

namespace Curtains.Application.DTO
{
    public class CurtainsDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
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
        public int? FabricId { get; set; }
        /// <summary>
        ///  This property represents MaterialId column.
        /// </summary>
        public int? MaterialId { get; set; }
        /// <summary>
        ///  This property represents AccessoriesId column.
        /// </summary>
        public int? AccessoriesId { get; set; }
        /// <summary>
        ///  This property represents CurtainsTypeId column.
        /// </summary>
        public int? CurtainsTypeId { get; set; }
        /// <summary>
        ///  This property represents CurtainsKindId column.
        /// </summary>
        public int? CurtainsKindId { get; set; }
        /// <summary>
        ///  This property represents price of curtains.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents purpose of curtains.
        /// </summary>
        public int? PurposeId { get; set; }
        #endregion

        #region NavigationProperties
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
        /// <summary>
        ///  This property represents purpose of curtians.
        /// </summary>
        public PurposeDTO Purpose { get; set; }
        #endregion
    }
}
