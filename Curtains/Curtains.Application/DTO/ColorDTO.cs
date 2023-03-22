using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> ColorDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class ColorDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents code of color.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///  This property represents color group of that color.
        /// </summary>
        public ColorGroupDTO ColorGroup { get; set; }
        #endregion
    }
}