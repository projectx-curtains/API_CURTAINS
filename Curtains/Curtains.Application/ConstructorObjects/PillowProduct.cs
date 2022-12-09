using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class PillowProduct : IProduct
    {
        /// <summary>
        ///  This property represents size of pillows.
        /// </summary>
        public string Title { get; set; }

        public string ToOrderMessage()
        {
            return $"<b>Подушка</b><br>Название: {Title}<br>";
        }
    }
}