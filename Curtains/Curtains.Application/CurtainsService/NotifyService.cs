using Curtains.Application.Interfaces;

namespace Curtains.Application.CurtainsService
{
    class NotifyService : INotifyService
    {
        private readonly IMessageSender _messageSender;
        private readonly IMessageBuilder _messageBuilder;
        public NotifyService(IMessageSender messageSender, IMessageBuilder messageBuilder)
        {
            _messageSender = messageSender;
            _messageBuilder = messageBuilder;
        }

        public async Task NotifyAsync()
        {
            //TODO придумать че с объектом делать
            string message = string.Empty;
            await _messageSender.SendAsync("hahahahhihihihih","jfsaign ijdsfjidjgids gijfnsif fjfnndkgm gdkfndjntjew");
        }
    }
}