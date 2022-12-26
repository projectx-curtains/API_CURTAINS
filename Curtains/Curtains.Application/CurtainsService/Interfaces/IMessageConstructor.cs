using Curtains.Application.ConstructorObjects;

namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the message constructor that construct message from order.
    /// </summary>
    public interface IMessageConstructor
    {
        public string Construct(Order order);
    }
}