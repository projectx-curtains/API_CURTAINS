using Curtains.Application.DTO;
using Curtains.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Curtains.Application.CurtainsService
{
    class NotifyService : INotifyService
    {
        private const string subject = "Вам поступил новый заказ!";
        private readonly IMessageSender _messageSender;
        private readonly IMessageConstructor _messageBuilder;
        private readonly IConfiguration _config;
        private readonly ILogger _logger;

        public NotifyService(IMessageSender messageSender,
                             IMessageConstructor messageBuilder,
                             IConfiguration config,
                             ILogger logger)
        {
            _messageSender = messageSender;
            _messageBuilder = messageBuilder;
            _config = config;
            _logger = logger;
        }

        public async Task NotifyAsync(OrderDTO order)
        {
            if (order is null)
            {
                throw new ArgumentNullException("Order is null", nameof(order));
            }

            string message = _messageBuilder.Construct(order);
            await _messageSender.SendAsync(subject, message, _config["EmailSettings:CustomerEmail"]);
        }

        public async Task NotifyAsync(ConstructorDTO constructorData)
        {
            if (constructorData is null)
            {
                throw new ArgumentNullException("Constructor data is null", nameof(constructorData));
            }

            string message = _messageBuilder.Construct(constructorData);
            await _messageSender.SendAsync(subject, message, _config["EmailSettings:CustomerEmail"]);
        }
    }
}