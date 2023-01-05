namespace Curtains.Application.DTO
{

    /// <summary>
    /// Class <c> OurWorksDTO </c> describes interaction model for ReviewController and database.
    /// </summary>
    public class OurWorksDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents description of the work we have done.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///  This property represents path to image of review.
        /// </summary>
        public string ImagePath { get; set; }
        #endregion
    }
}
