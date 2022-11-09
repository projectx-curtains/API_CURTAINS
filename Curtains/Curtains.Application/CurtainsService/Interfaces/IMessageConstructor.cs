using Curtains.Application.DTO;

namespace Curtains.Application.Interfaces
{
    public interface IMessageConstructor
    {
        public string Construct(OrderDTO order);
    }
}