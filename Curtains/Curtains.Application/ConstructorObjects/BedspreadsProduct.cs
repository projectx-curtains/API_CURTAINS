using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class BedspreadsProduct : IProduct
    {
        /// <summary>
        ///  This property represents size of pillows.
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        ///  This property represents filler of pillows.
        /// </summary>
        public string Filler { get; set; }
        /// <summary>
        ///  This property represents situation, if cover of pillows is removable.
        /// </summary>
        public bool RemovableCover { get; set; }
        /// <summary>
        ///  This property represents price of pillows.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents shape of pillows.
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        ///  This property represents fabric of pillows.
        /// </summary>
        public string FabricTitle { get; set; }

        public string ToOrderMessage()
        {
            return "BedSpread";
        }
    }
}