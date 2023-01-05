using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class FabricProduct : IProduct
    {
        /// <summary>
        ///  This property represents Title of fabric.
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        ///  Method returning a message about the fabric product required for the order
        /// </summary>
        public string ToOrderMessage()
        {
            return $"<b>Ткань</b><br>Название: {Title}<br>";
        }
    }
}