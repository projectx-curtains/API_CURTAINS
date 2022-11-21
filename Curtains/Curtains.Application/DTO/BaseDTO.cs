using System;
namespace Curtains.Application.DTO
{
    public abstract class BaseDTO
    {
        #region PropertiesRegion
        /// <summary>
        /// This property represents unique identifier for data tranfer objects.
        /// </summary>
        public int Id { get; set; }
        #endregion
    }
}

