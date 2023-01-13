using System;
using Curtains.Application.DTO.Interfaces;

namespace Curtains.Application.DTO
{
    public class BaseExtendedDTO : BaseExtendedByTitleDTO, IBaseExtendedDto
    {
        #region PropertiesRegion
        /// <summary>
        /// This property represents description for data tranfer objects.
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}

