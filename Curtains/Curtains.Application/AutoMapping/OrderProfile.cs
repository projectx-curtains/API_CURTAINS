using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, ConstructorDTO>()
                .ForMember(x => x.Curtains, o => o.Ignore()).ReverseMap();
            CreateMap<Order, OrderDTO>()
                .ForMember(x => x.ProductIds, o => o.Ignore()).ReverseMap();
        }
    }
}
