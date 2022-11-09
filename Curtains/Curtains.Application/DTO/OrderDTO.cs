namespace Curtains.Application.DTO
{
    public class OrderDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents comment to order.
        /// </summary>
        public string Comment { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        ICollection<int> MarketingInfosId { get; set; } = new List<int>();
    }
}
