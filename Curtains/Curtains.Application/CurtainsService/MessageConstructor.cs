using Curtains.Application.DTO;
using Curtains.Application.Interfaces;
using System.Text;

namespace Curtains.Application.CurtainsService
{
    class MessageConstructor : IMessageConstructor
    {
        private const string customerName = "Раиса Леонидовна";
        public string Construct(OrderDTO order)
        {
            //TODO Сделать сообщение для каталога когда предоставят пример
            return "";
        }

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
            return new StringBuilder().Append("Добрый день, ").Append(customerName).Append("<br>К вам поступил заказ: ");
        }

        private string Build(StringBuilder sb, string phoneNumber, string comment)
        {
            return sb.Append("<b><br>Номер телефона - ").Append(phoneNumber).Append("</b>")
                    .Append("<b><br>Комментарий к заказу - ").Append(comment).Append("</b>").ToString();
        }
    }
}