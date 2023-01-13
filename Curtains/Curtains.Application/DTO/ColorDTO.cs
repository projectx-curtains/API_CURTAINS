using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curtains.Application.DTO.Interfaces;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> ColorDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class ColorDTO : BaseExtendedDTO, IColorDto
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents code of color.
        /// </summary>
        public string Code { get; set; }
        #endregion
    }
}