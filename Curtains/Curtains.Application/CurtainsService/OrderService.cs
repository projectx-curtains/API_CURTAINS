using AutoMapper;
using Curtains.Application.AutoMapping;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            var orders = _mapper.Map<IEnumerable<OrderDTO>>(_orderRepository.GetAll());
            return orders;
        }

        public async Task InsertAsync(OrderDTO entity, CancellationToken cancelationToken)
        {
            var order = _mapper.Map<OrderModel>(entity);
            await _orderRepository.InsertAsync(order, cancelationToken);
        }
    }
}
