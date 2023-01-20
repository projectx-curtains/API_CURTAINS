using System.Security.AccessControl;

namespace Curtains.Application.DTO
{
    public class CurtainsDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
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
        ///  This property represents fabric of curtains.
        /// </summary>
        public virtual FabricDTO Fabric { get; set; }
        /// <summary>
        ///  This property represents material of curtains.
        /// </summary>
        public virtual MaterialDTO Material { get; set; }
        /// <summary>
        ///  This property represents accessories of curtains.
        /// </summary>
        public virtual AceEnumerator Accessories { get; set; }
        /// <summary>
        ///  This property represents type of curtains.
        /// </summary>
        public virtual CurtainsTypeDTO CurtainsType { get; set; }
        /// <summary>
        ///  This property represents kind of curtains.
        /// </summary>
        public virtual CurtainsKindDTO CurtainsKind { get; set; }
        /// <summary>
        ///  This property represents of Bracing.
        /// </summary>
        public virtual BracingDTO Bracing { get; set; }
        /// <summary>
        ///  This property represents of Color.
        /// </summary>
        public virtual ColorDTO Color { get; set; }
        #endregion
    }
}
