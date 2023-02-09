namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the notifying service.
    /// </summary>
    public interface INotifyService
    {
        public Task NotifyAsync(object order);
    }
}