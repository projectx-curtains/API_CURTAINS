using Curtains.Application.DTO.Interfaces;

namespace Curtains.Application.DTO
{
    public class BaseExtendedByTitleDTO : BaseDTO, IBaseExtendedByTitleDto
    {
        #region PropertiesRegion
        /// <summary>
        /// This property represents title for data tranfer objects.
        /// </summary>
        public string Title { get; set; }
        #endregion
    }
}

