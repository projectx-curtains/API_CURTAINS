using Curtains.Application.ConstructorObjects.Interfaces;

namespace Curtains.Application.ConstructorObjects
{
    public class BedspreadsProduct : IProduct
    {
        /// <summary>
        ///  This property represents Title of bedspreads.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///  Method returning a message about the bedspreads product required for the order
        /// </summary>
        public string ToOrderMessage()
        {
            return $"<b>Покрывало</b><br>Название: {Title}<br>";
        }
    }
}