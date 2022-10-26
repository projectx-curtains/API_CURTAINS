using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes fabric model.
    /// </summary>
    public class FabricModel : ExtendedBaseEntity
    {
        public FabricModel()
        {
            Curtains = new HashSet<CurtainsModel>();
            Bedspreads = new HashSet<BedspreadsModel>();
            Pillows = new HashSet<PillowsModel>();
        }

        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if fabric is dense or not.
        /// </summary>
        public bool Density { get; set; }
        /// <summary>
        ///  This property represents ConsistencyId column.
        /// </summary>
        public int ConsistencyId { get; set; }
        /// <summary>
        ///  This property represents ColorId column.
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        ///  This property represents DecorationId column.
        /// </summary>
        public int DecorationId { get; set; }
        /// <summary>
        ///  This property represents ManufacturerId column.
        /// </summary>
        public int ManufacturerId { get; set; }
        /// <summary>
        ///  This property represents price of fabric.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents length of fabric.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///  This property represents wifth of fabric.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents situation, if there is design on fabric or not.
        /// </summary>
        public bool Design { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        ///  This property represents consistency of fabric.
        /// </summary>
        public virtual ConsistencyModel Consistency { get; set; }
        /// <summary>
        ///  This property represents color of fabric.
        /// </summary>
        public virtual ColorModel Color { get; set; }
        public virtual DecorationsModel Decorations { get; set; }
        /// <summary>
        ///  This property represents decorations of fabric.
        /// </summary>
        public virtual ManufacturerModel Manufacturer { get; set; }
        /// <summary>
        ///  This property represents list of curtains with that fabric.
        /// </summary>
        public virtual ICollection<CurtainsModel> Curtains { get; set; }
        /// <summary>
        ///  This property represents list of bedspreads with that fabric.
        /// </summary>
        public virtual ICollection<BedspreadsModel> Bedspreads { get; set; }
        /// <summary>
        ///  This property represents list of pillows with that fabric.
        /// </summary>
        public virtual ICollection<PillowsModel> Pillows { get; set; }
        #endregion
    }
}
