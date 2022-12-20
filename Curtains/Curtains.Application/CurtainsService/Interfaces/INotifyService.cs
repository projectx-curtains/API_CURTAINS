namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface INotifyService
    {
        public Task NotifyAsync(object order);
    }
}