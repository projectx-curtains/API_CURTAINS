using Curtains.Application.ConstructorObjects;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IMessageConstructor
    {
        public string Construct(Order order);
    }
}