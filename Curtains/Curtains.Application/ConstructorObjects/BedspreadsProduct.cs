using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class BedspreadsProduct : IProduct
    {
        /// <summary>
        ///  This property represents size of pillows.
        /// </summary>
        public string Title { get; set; }

        public string ToOrderMessage()
        {
            return $"<b>Покрывало</b><br>Название: {Title}<br>";
        }
    }
}