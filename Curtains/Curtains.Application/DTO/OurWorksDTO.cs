using Curtains.Domain.Models;

namespace Curtains.Application.DTO
{

    /// <summary>
    /// Class <c> OurWorksDTO </c> describes interaction model for ReviewController and database.
    /// </summary>
    public class OurWorksDTO : BaseExtendedByTitleDTO
    {
        #region PropertiesRegion

        /// <summary>
        ///  This property represents path to image of review.
        /// </summary>
        public string ImagePath { get; set; }
        #endregion
    }
}
