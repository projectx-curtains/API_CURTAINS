using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Curtains.Domain.Models;

namespace Curtains.Application.DTO
{

    /// <summary>
    /// Class <c> ReviewDTO </c> describes interaction model for ReviewController and database.
    /// </summary>
    public class ReviewDTO : BaseDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents name of person, who left the review.
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        ///  This property represents country of person, who left the review.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        ///  This property represents city of person, who left the review.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        ///  This property represents review.
        /// </summary>
        public string Review { get; set; }
        /// <summary>
        ///  This property represents path to image of review.
        /// </summary>
        public string ImagePath { get; set; }
        #endregion
    }
}
