using Curtains.Application.DTO;

namespace Curtains.Application.Interfaces
{
    public interface INotifyService
    {
        public Task NotifyAsync(OrderDTO order);
        public Task NotifyAsync(ConstructorDTO data);
    }
}