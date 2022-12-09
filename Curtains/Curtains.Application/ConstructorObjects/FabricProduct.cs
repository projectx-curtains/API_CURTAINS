using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class FabricProduct : IProduct
    {
        /// <summary>
        ///  This property represents situation, if fabric is dense or not.
        /// </summary>
        public string Title { get; set; }

        public string ToOrderMessage()
        {
            return $"<b>Ткань</b><br>Название: {Title}<br>";
        }
    }
}