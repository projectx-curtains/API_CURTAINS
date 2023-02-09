namespace Curtains.Application.DTO
{
    public class ConstructorDTO
    {
        /// <summary>
        /// Curtains designed by the user
        /// </summary>
        public IEnumerable<CurtainsDTO> Curtains { get; set; }
        /// <summary>
        /// User phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// User comment to the order
        /// </summary>
        public string Comment { get; set; }
    }
}
