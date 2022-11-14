using Curtains.Application.DTO;
using Curtains.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Notifies the customer of an order
    /// </summary>
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

        /// <summary>
        /// Sends a message to the customer based on existing products
        /// </summary>
        /// <param name="order">Order information and item numbers</param>
        /// <exception cref="ArgumentNullException">Throws an error if the argument is null</exception>
        public async Task NotifyAsync(OrderDTO order)
        {
            if (order is null)
            {
                _logger.LogError("Order is null");
                throw new ArgumentNullException(nameof(order), "Order is null");
            }

            string message = _messageBuilder.Construct(order);
            await _messageSender.SendAsync(subject, message, _config["EmailSettings:CustomerEmail"]);
        }

        /// <summary>
        /// Sends a message to the customer based on the order information
        /// </summary>
        /// <param name="constructorData">Information about order</param>
        /// <exception cref="ArgumentNullException">Throws an error if the argument is null</exception>
        public async Task NotifyAsync(ConstructorDTO constructorData)
        {
            if (constructorData is null)
            {
                _logger.LogError("Constructor data is null");
                throw new ArgumentNullException(nameof(constructorData), "Constructor data is null");
            }

            string message = _messageBuilder.Construct(constructorData);
            await _messageSender.SendAsync(subject, message, _config["EmailSettings:CustomerEmail"]);
        }
    }
}