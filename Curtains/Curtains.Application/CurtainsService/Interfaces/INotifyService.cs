using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsServices.Interfaces
{
    public interface INotifyService
    {
        public Task NotifyAsync(object order);
    }
}