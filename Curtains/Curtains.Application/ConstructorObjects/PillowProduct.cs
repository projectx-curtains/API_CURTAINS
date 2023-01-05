using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class PillowProduct : IProduct
    {
        /// <summary>
        ///  This property represents title of pillows.
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        ///  Method returning a message about the pillow product required for the order
        /// </summary>
        public string ToOrderMessage()
        {
            return $"<b>Подушка</b><br>Название: {Title}<br>";
        }
    }
}