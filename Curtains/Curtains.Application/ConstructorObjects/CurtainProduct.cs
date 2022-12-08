using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class CurtainProduct : IProduct
    {
        /// <summary>
        /// Curtain height
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Curtain width
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// The number of such curtains in the order
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Type of curtains
        /// </summary>
        public string CurtainsType { get; set; }
        /// <summary>
        /// Curtain fabric design
        /// </summary>
        public string Design { get; set; }
        /// <summary>
        /// Fabric type
        /// </summary>
        public string FabricType { get; set; }
        /// <summary>
        /// Curtain color
        /// </summary>
        public string Color { get; set; }

        public string ToOrderMessage()
        {
            return "Curtain";
        }
    }
}