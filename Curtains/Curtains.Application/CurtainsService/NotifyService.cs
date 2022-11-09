using Curtains.Application.Interfaces;

namespace Curtains.Application.CurtainsService
{
    class NotifyService : INotifyService
    {
        private readonly IMessageSender _messageSender;
        private readonly IMessageConstructor _messageBuilder;

        public NotifyService(IMessageSender messageSender, IMessageConstructor messageBuilder)
        {
            _messageSender = messageSender;
            _messageBuilder = messageBuilder;
        }

        public async Task NotifyAsync()
        {
            //TODO придумать че с объектом делать
            string message = string.Empty;
            await _messageSender.SendAsync();
        }
    }
}