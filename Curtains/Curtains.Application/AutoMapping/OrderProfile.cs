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
            CreateMap<ConstructorDTO, Order>()
                .ForMember(x => x.Products, o => o.MapFrom(x => x.Curtains)).ReverseMap();
            CreateMap<Order, OrderDTO>()
                .ForMember(x => x.ProductIds, o => o.Ignore());
        }
    }
}
