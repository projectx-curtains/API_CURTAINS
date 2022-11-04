using System;
namespace Curtains.Application.DTO
{
    public class BaseExtendedDTO : BaseDTO
    {
        #region PropertiesRegion
        /// <summary>
        /// This property represents title for data tranfer objects.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// This property represents description for data tranfer objects.
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}

