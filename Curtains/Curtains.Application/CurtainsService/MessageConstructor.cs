using Curtains.Application.ConstructorObjects;
using Curtains.Application.CurtainsServices.Interfaces;
using System.Text;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Constructs order messages
    /// </summary>
    class MessageConstructor : IMessageConstructor
    {
        private const string customerName = "Раиса Леонидовна";

        /// <summary>
        /// Constructs order messages based on the order
        /// </summary>
        /// <param name="order">Information about order</param>
        /// <returns>A message that describes the user's order</returns>
        /// <exception cref="ArgumentException">Throws an error if the object does not contain information about curtains</exception>
        public string Construct(Order order)
        {
            if(!order.Products.Any())
            {
                throw new ArgumentException("Products is empty", nameof(order.Products));
            }

            var sb = BeginConstruct();

            foreach (var entity in order.Products)
            {
                sb.Append(entity.ToOrderMessage());
            }


            return Build(sb, order.PhoneNumber, order.Comment);
        }

        private StringBuilder BeginConstruct()
        {
            return new StringBuilder().Append($"Добрый день, {customerName}<br>К вам поступил заказ: ");
        }

        private string Build(StringBuilder sb, string phoneNumber, string comment)
        {
            return sb.Append($"<b><br>Номер телефона - {phoneNumber}<br>Комментарий к заказу - {comment}</b>").ToString();
        }
    }
}