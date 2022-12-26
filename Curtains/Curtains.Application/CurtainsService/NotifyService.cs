using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Infrastructure.Shared.Exceptions;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Notifies the customer of an order
    /// </summary>
    class NotifyService : INotifyService
    {
        private const string _subject = "Вам поступил новый заказ!";
        private const string _customerEmail = "email@gmail.com";
        private readonly IMessageSender _messageSender;
        private readonly IMessageConstructor _messageConstructor;
        private readonly IProductImageService _productImageService;
        private readonly IImageToProductConversionService _converter;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public NotifyService(IMessageSender messageSender,
                             IMessageConstructor messageConstructor,
                             IProductImageService productImageService,
                             IImageToProductConversionService converter,
                             IMapper mapper,
                             ILogger logger)
        {
            _messageSender = messageSender;
            _messageConstructor = messageConstructor;
            _productImageService = productImageService;
            _converter = converter;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Notifies the client about the receipt of the order, depending on where the order is made from
        /// </summary>
        public async Task NotifyAsync(object order)
        {
            string message;
            var deserializedOrder = JsonSerializer.Deserialize<OrderDTO>(order.ToString());

            // TODO: Make this switch cleaner
            switch (deserializedOrder.Comment)
            {
                case null:
                    _logger.LogError("Wrong type of order");
                    throw new WrongTypeOfOrderException(nameof(order));
                default:
                    if (deserializedOrder.ProductIds is null)
                    {
                        message = _messageConstructor.Construct(_mapper.Map<Order>(JsonSerializer.Deserialize<ConstructorDTO>(order.ToString())));
                    }
                    else
                    {
                        var orderFromCatalog = _mapper.Map<Order>(deserializedOrder);
                        orderFromCatalog.Products = _converter.ConvertAll(await _productImageService.GetAllByIdAsync(deserializedOrder.ProductIds));
                        message = _messageConstructor.Construct(orderFromCatalog);
                    }
                    break;
            }

            await _messageSender.SendMessageToCustomerAsync(_subject, message, _customerEmail);
        }
    }
}