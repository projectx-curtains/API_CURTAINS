using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Domain.Models
{
    public class ColorGroupModel : ExtendedByTitleBaseEntity
    {
        #region Properties
        public int ColorId { get; set; }
        #endregion
        #region NavigationProperties
        public virtual ColorModel Color { get; set; }
        #endregion
    }
}
