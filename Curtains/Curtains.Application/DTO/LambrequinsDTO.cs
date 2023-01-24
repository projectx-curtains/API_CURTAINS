using Curtains.Domain.Models;
using Curtains.Infrastructure.Repositories;

namespace Curtains.Application.DTO
{
    public class LambrequinsDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents price of lambrequins.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents height of lambrequins.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        ///  This property represents width of lambrequins.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents color of lambrequins.
        /// </summary>
        public ColorDTO Color { get; set; }
        /// <summary>
        ///  This property represents bracing of lambrequins.
        /// </summary>
        public BracingDTO Bracing { get; set; }
        /// <summary>
        ///  This property represents fabricKind of lambrequins.
        /// </summary>
        public FabricKindDTO FabricKind { get; set; }
        #endregion
    }
}
