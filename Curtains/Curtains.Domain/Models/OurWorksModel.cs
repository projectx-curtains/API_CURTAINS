namespace Curtains.Domain.Models
{
    /// <summary>
    ///  This class describes model of works, that are shown to customers on website.
    /// </summary>
    public class OurWorksModel : ExtendedByTitleBaseEntity
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents path to image of our works.
        /// </summary>
        public string ImagePath { get; set; }
        #endregion

    }
}
