using Curtains.Application.ConstructorObjects.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Application.ConstructorObjects
{
    public class SetProduct : IProduct
    {
        /// <summary>
        ///  This property represents price of product set.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents curtains in that product set.
        /// </summary>
        public CurtainsDTO Curtains { get; set; }
        /// <summary>
        ///  This property represents pillows in that product set.
        /// </summary>
        public PillowsDTO Pillows { get; set; }
        /// <summary>
        ///  This property represents bedspreads in that product set.
        /// </summary>
        public BedspreadsDTO Bedspreads { get; set; }

        public string ToOrderMessage()
        {
            return "Set";
        }
    }
}