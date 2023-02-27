using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.DTO
{
    /// <summary>
    /// Class <c> DecorationsDTO </c> describes interaction model for NewItemsController and database.
    /// </summary>
    public class DecorationsDTO : BaseExtendedByTitleDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents situation, if there are decorations on fabric or not.
        /// </summary>
        public bool Presence { get; set; }
        #endregion
    }
}