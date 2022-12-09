using System;
namespace Curtains.Application.DTO
{
    public class BaseExtendedDTO : BaseExtendedByTitleDTO
    {
        #region PropertiesRegion
        /// <summary>
        /// This property represents description for data tranfer objects.
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}

