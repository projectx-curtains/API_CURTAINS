using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Application.Interfaces;
using Curtains.Infrastructure.Interfaces;
using System.Text;

namespace Curtains.Application.CurtainsService
{
    class MessageConstructor : IMessageConstructor
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public MessageConstructor(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public string Construct(OrderDTO order)
        {
            var sb = new StringBuilder();
            sb.Append("������ ���� ����� ����������.\n" + 
                      "� ��� �������� �����:");
            

            
            sb.Append("����� �������� - " + order.PhoneNumber + "\n" +
                      "����������� � ������ - " + order.Comment);

            return new string("")
        }
    }
}