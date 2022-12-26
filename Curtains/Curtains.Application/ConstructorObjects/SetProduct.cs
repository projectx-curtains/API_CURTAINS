using Curtains.Application.ConstructorObjects.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Application.ConstructorObjects
{
    public class SetProduct : IProduct
    {
        /// <summary>
        ///  This property represents title of product set.
        /// </summary>
        public string Title {get; set; }


        /// <summary>
        ///  Method returning a message about the set product required for the order
        /// </summary>
        public string ToOrderMessage()
        {
            return $"<b>Комплект</b><br>Название: {Title}<br>";
        }
    }
}