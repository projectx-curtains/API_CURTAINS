using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class FabricProduct : IProduct
    {
        /// <summary>
        ///  This property represents situation, if fabric is dense or not.
        /// </summary>
        public bool Density { get; set; }
        /// <summary>
        ///  This property represents price of fabric.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents length of fabric.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///  This property represents wifth of fabric.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        ///  This property represents situation, if there is design on fabric or not.
        /// </summary>
        public bool Design { get; set; }

        public string ToOrderMessage()
        {
            return "Fabric";
        }
    }
}