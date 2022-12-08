namespace Curtains.Application.DTO
{
    public class OrderDTO
    {
        #region PropertiesRegion
        /// <summary>
        ///  This property represents comment to order.
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// User phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Numbers of existing products ordered by the user
        /// </summary>
        public int[] ProductIds { get; set; }
        #endregion
    }
}
