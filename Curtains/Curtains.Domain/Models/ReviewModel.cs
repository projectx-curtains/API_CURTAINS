namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes review model.
    /// </summary>
    public class ReviewModel : BaseEntity
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
