using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.ConstructorObjects.Interfaces;
using Curtains.Application.CurtainsServices.Interfaces;
using Curtains.Application.DTO;
using Curtains.Infrastructure.Shared.Exceptions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Notifies the customer of an order
    /// </summary>
    class NotifyService : INotifyService
    {
        private const string _subject = "Вам поступил новый заказ!";
        private readonly IMessageSender _messageSender;
        private readonly IMessageConstructor _messageBuilder;
        private readonly IProductImageService _productImageService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly ILogger _logger;

        public NotifyService(IMessageSender messageSender,
                             IMessageConstructor messageConstructor,
                             IProductImageService productImageService,
                             IMapper mapper,
                             IConfiguration config,
                             ILogger logger)
        {
            _messageSender = messageSender;
            _messageBuilder = messageConstructor;
            _productImageService = productImageService;
            _mapper = mapper;
            _config = config;
            _logger = logger;
        }

        public async Task NotifyAsync(object order)
        {
            string message;
            switch (order)
            {
                case OrderDTO orderFromCatalog:
                    message = await GetMessageFromCatalogAsync(orderFromCatalog);
                    break;
                case ConstructorDTO orderFromConstructor:
                    message = GetMessageFromConstructor(orderFromConstructor);
                    break;
                default:
                    _logger.LogError("Wrong type of order");
                    throw new WrongTypeOfOrderException(nameof(order));
            }

            await _messageSender.SendAsync(_subject, message, _config["EmailSettings:CustomerEmail"]);
        }

        /// <summary>
        /// Sends a message to the customer based on existing products
        /// </summary>
        /// <param name="order">Order information and item numbers</param>
        /// <exception cref="ArgumentNullException">Throws an error if the argument is null</exception>
        private async Task<string> GetMessageFromCatalogAsync(OrderDTO order)
        {
            List<IProduct> products = new();
            foreach (var id in order.ProductIds)
            {
                var productImage = await _productImageService.GetByIdAsync(id);

                IProduct product = productImage switch
                {
                    { Bedspreads: not null} => _mapper.Map<BedspreadsProduct>(productImage.Bedspreads),
                    { Curtains: not null} => _mapper.Map<CurtainProduct>(productImage.Curtains),
                    { Pillows: not null} => _mapper.Map<PillowProduct>(productImage.Pillows),
                    { Sets: not null} => _mapper.Map<SetProduct>(productImage.Sets),
                    { Fabrics: not null} => _mapper.Map<FabricProduct>(productImage.Fabrics),
                };

                products.Add(product);
            }

            return _messageBuilder.Construct(new Order()
            {
                PhoneNumber = order.PhoneNumber,
                Comment = order.Comment,
                Products = products
            });
        }

        /// <summary>
        /// Sends a message to the customer based on the order information
        /// </summary>
        /// <param name="constructorData">Information about order</param>
        /// <exception cref="ArgumentNullException">Throws an error if the argument is null</exception>
        private string GetMessageFromConstructor(ConstructorDTO constructorData)
        {
            return _messageBuilder.Construct(new Order()
            {
                PhoneNumber = constructorData.PhoneNumber,
                Comment = constructorData.Comment,
                Products = _mapper.Map<IEnumerable<CurtainProduct>>(constructorData.Curtains),
            });
        }
    }
}