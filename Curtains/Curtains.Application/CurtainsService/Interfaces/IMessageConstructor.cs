using Curtains.Application.ConstructorObjects;

namespace Curtains.Application.CurtainsServices.Interfaces
{
    public interface IMessageConstructor
    {
        public string Construct(Order order);
    }
}