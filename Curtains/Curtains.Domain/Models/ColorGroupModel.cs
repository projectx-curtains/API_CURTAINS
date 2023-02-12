using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ColorGroupModel : ExtendedByTitleBaseEntity
    {
        #region NavigationProperties
        /// <summary>
        ///  This property represents color of that color.
        /// </summary>
        public virtual ICollection<ColorModel> Colors { get; set; }
        #endregion
    }
}
