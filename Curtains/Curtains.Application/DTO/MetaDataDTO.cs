namespace Curtains.Application.DTO
{
    public class MetaDataDTO : BaseExtendedDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents Key of meta data.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        ///  This property represents Canonical info of meta data.
        /// </summary>
        public string Canonical { get; set; }
        #endregion
    }
}
