using Curtains.Application.DTO;
using Curtains.Application.Interfaces;
using System.Text;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Constructs order messages
    /// </summary>
    class MessageConstructor : IMessageConstructor
    {
        /// <summary>
        /// Constructs order message based on existing products
        /// </summary>
        /// <param name="order">Order information and item numbers</param>
        /// <returns>A message that describes the user's order</returns>
        public string Construct(OrderDTO order)
        {
            //TODO Сделать сообщение для каталога когда предоставят пример
            return "";
        }

        /// <summary>
        /// Constructs order messages based on the order
        /// </summary>
        /// <param name="order">Information about order</param>
        /// <returns>A message that describes the user's order</returns>
        /// <exception cref="ArgumentNullException">Throws an error if the object does not contain information about curtains</exception>
        public string Construct(ConstructorDTO order)
        {
            if(!order.Curtains.Any())
            {
                throw new ArgumentNullException("Curtains is null", nameof(order.Curtains));
            }

            var sb = BeginConstruct();

            foreach (var entity in order.Curtains)
            {
                sb.Append("<br><b>Шторы</b>")
                .Append("<br>Размеры - ").Append(entity.Height).Append("x").Append(entity.Width)
                .Append("<br>Количество, шт. - ").Append(entity.Count)
                .Append("<br>Вид штор - ").Append(entity.CurtainsType)
                .Append("<br>Вид ткани - ").Append(entity.FabricType)
                .Append("<br>Дизайн - ").Append(entity.Design)
                .Append("<br>Цвет - ").Append(entity.Color);
            }


            return Build(sb, order.PhoneNumber, order.Comment);
        }

        private StringBuilder BeginConstruct()
        {
            return new StringBuilder().Append("Добрый день, Раиса Леонидовна.<br>К вам поступил заказ: ");
        }

        private string Build(StringBuilder sb, string phoneNumber, string comment)
        {
            return sb.Append("<b><br>Номер телефона - ").Append(phoneNumber).Append("</b>")
                    .Append("<b><br>Комментарий к заказу - ").Append(comment).Append("</b>").ToString();
        }
    }
}